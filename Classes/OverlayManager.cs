using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Aquarius
{
    public class OverlayManager
    {
        #region Instance
        private static OverlayManager _Instance;
        public static OverlayManager Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new OverlayManager();
                return _Instance;
            }
        }
        private static readonly log4net.ILog _Log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        #endregion Instance

        private HttpListener _HttpListener;
        private Thread _Thread;
        private List<Tuple<string, WebSocket>> _ActiveWebSockets;
        private const string URL_TEMPLATE = "http://localhost:{PORT_NUMBER}/socket/{PAGE_NAME}/";

        public OverlayManager()
        {
        }

        public void Initialize()
        {
            _ActiveWebSockets = new List<Tuple<string, WebSocket>>();

            if (_HttpListener != null && _HttpListener.IsListening)
            {
                _HttpListener.Stop();
                _HttpListener.Close();
            }

            _HttpListener = new HttpListener();

            string[] templatePaths = Directory.GetFiles("Pages", "*-template.js", SearchOption.TopDirectoryOnly);
            foreach(string templatePath in templatePaths)
            {
                FileInfo template = new FileInfo(templatePath);
                FileInfo newFile = new FileInfo(template.FullName.Replace("-template.js", ".js"));

                if (!template.Exists)
                    continue;

                File.WriteAllText(newFile.FullName, File.ReadAllText(template.FullName).Replace("{PORT_NUMBER}", SettingsManager.Instance.Settings.PortNumber.ToString()));
                _HttpListener.Prefixes.Add(
                    URL_TEMPLATE
                    .Replace("{PORT_NUMBER}", SettingsManager.Instance.Settings.PortNumber.ToString())
                    .Replace("{PAGE_NAME}", Path.GetFileNameWithoutExtension(newFile.Name)));
            }

            try
            {
                _HttpListener.Start();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to start listening on specified port number: " + ex.Message);
            }

            if (_Thread != null && _Thread.IsAlive)
            {
                _Thread.Abort();
                _Thread.Join();
            }

            _Thread = new Thread(new ThreadStart(DoWork));
            _Thread.IsBackground = true;
            _Thread.Name = "OverlayManager";
            _Thread.Start();
        }

        internal void DoWork()
        {
            while (true)
            {
                try
                {
                    HttpListenerContext context = _HttpListener.GetContextAsync().Result;
                    if (context.Request.IsWebSocketRequest)
                    {
                        HttpListenerWebSocketContext webSocketContext = context.AcceptWebSocketAsync(null).Result;
                        string uri = context.Request.Url.ToString();
                        Tuple<string, WebSocket> newWebSocket = new Tuple<string, WebSocket>(uri, webSocketContext.WebSocket);

                        _ActiveWebSockets.RemoveAll(q => q.Item1 == newWebSocket.Item1);
                        _ActiveWebSockets.Add(newWebSocket);

                        if (SettingsManager.Instance.Settings.RefreshOnLoad)
                            RefreshWebSocket(newWebSocket);
                    }
                }
                catch (Exception ex)
                {
                    _Log.Error("Exception in DoWork: " + ex.ToString());
                }
            }
        }

        public void RefreshActiveWebSockets()
        {
            foreach (Tuple<string, WebSocket> webSocket in _ActiveWebSockets)
                RefreshWebSocket(webSocket);
        }

        private void RefreshWebSocket(Tuple<string, WebSocket> webSocket)
        {
            IOverlayInfo displayOverlay;

            if (!_ActiveWebSockets.Contains(webSocket))
                return;

            // If we had different kinds of DisplayOverlays, we would have to figure out which one to generate based on which web socket we're sending to here.
            displayOverlay = new DisplayOverlay_Prediction();

            string value = "{OVERLAY_INFO}";
            value += JsonConvert.SerializeObject(displayOverlay);
            byte[] segmentsBytes = Encoding.UTF8.GetBytes(value);

            Send(webSocket.Item1, new ArraySegment<byte>(segmentsBytes));
        }

        private void Send(string targetUri, ArraySegment<byte> outputBuffer)
        {
            for (int i = _ActiveWebSockets.Count - 1; i >= 0; i--)
            {
                string uri = _ActiveWebSockets[i].Item1;
                WebSocket webSocket = _ActiveWebSockets[i].Item2;

                if (uri != targetUri)
                    continue;

                try
                {
                    webSocket.SendAsync(outputBuffer, WebSocketMessageType.Text, true, CancellationToken.None);
                }
                catch (Exception ex)
                {
                    _Log.Error(ex.ToString());
                    webSocket.Abort();
                    webSocket.Dispose();
                    _ActiveWebSockets.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
