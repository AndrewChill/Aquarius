using Newtonsoft.Json;
using System;
using TwitchLib.Client;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Models;
using System.Reflection;
using RestSharp;

namespace Aquarius
{
    public class TwitchManager
    {
        #region Instance
        private static TwitchManager _Instance;
        public static TwitchManager Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new TwitchManager();
                return _Instance;
            }
        }
        private static readonly log4net.ILog _Log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        #endregion Instance

        private TwitchClient _TwitchClient;
        private string _TwitchChannel;
        private string _BroadcasterId;

        public void Initialize()
        {
            _TwitchChannel = SettingsManager.Instance.Settings.TwitchChannel;
            _BroadcasterId = GetBroadcasterId();

            if (_BroadcasterId == null)
                throw new Exception("Failed to retrieve BroadcasterId. Check your Twitch Integration settings.");

            ConnectionCredentials credentials = new ConnectionCredentials(_TwitchChannel, SettingsManager.Instance.Settings.TwitchToken);
            var clientOptions = new ClientOptions
            {
                MessagesAllowedInPeriod = 750,
                ThrottlingPeriod = TimeSpan.FromSeconds(30)
            };

            if (_TwitchClient != null)
                _TwitchClient.Disconnect();

            _TwitchClient = new TwitchClient(new WebSocketClient(clientOptions));
            _TwitchClient.Initialize(credentials, "channel");
            _TwitchClient.Connect();
        }

        public string GetBroadcasterId()
        {
            var client = new RestClient("https://api.twitch.tv/helix/users?login=" + SettingsManager.Instance.Settings.TwitchChannel);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("client-id", SettingsManager.Instance.Settings.TwitchClientId);
            request.AddHeader("Authorization", "Bearer " + SettingsManager.Instance.Settings.TwitchToken);
            IRestResponse response = client.Execute(request);
            UserCollection results = JsonConvert.DeserializeObject<UserCollection>(response.Content);
            if (results == null || results.data == null || results.data.Count < 1)
                return null;
            return results.data[0].id;
        }

        public Prediction GetCurrentPrediction()
        {
            try
            {
                var client = new RestClient("https://api.twitch.tv/helix/predictions?first=1&broadcaster_id=" + _BroadcasterId);
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("client-id", SettingsManager.Instance.Settings.TwitchClientId);
                request.AddHeader("Authorization", "Bearer " + SettingsManager.Instance.Settings.TwitchToken);
                IRestResponse response = client.Execute(request);
                PredictionCollection predictionCollection = JsonConvert.DeserializeObject<PredictionCollection>(response.Content);
                if (predictionCollection == null || predictionCollection.data == null || predictionCollection.data.Count < 1)
                    return null;
                return predictionCollection.data[0];
            }
            catch (Exception ex)
            {
                _Log.Error("Exception in GetCurrentPrediction: " + ex.ToString());
                return null;
            }
        }
    }
}
