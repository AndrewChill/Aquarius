
// We want the user to be able to specify the port number for their web socket to run on,
// but we don't have a good way to modify this static js file. So, we use this file as
// a template, and when running the app, this template file is copied to 'overlay-prediction.js'
// and the {PORT_NUMBER} value is replaced with the port number specified by the user.

var wsUri = "ws://localhost:{PORT_NUMBER}/socket/overlay-prediction-left/";

function init() {
    websocket = new WebSocket(wsUri);
    websocket.onopen = function (evt) { onOpen(evt) };
    websocket.onclose = function (evt) { onClose(evt) };
    websocket.onmessage = function (evt) { onMessage(evt) };
    websocket.onerror = function (evt) { onError(evt) };
}

function onOpen(evt) {
    console.log("Websocket connected.");
}

function onClose(evt) {
    console.log("Websocket disconnected.");
}

function onError(evt) {
    console.log("Error: " + evt.data);
}

function doSend(message) {
    console.log("Send: " + message);
    websocket.send(message);
}

function onMessage(evt) {
    var message = evt.data;
    console.log("Message: " + message);

    if (message.startsWith("{OVERLAY_INFO}")) {
        message = message.replace("{OVERLAY_INFO}", "");
        var value = JSON.parse(message);
        displayOverlayInfo(value)
    }
}

function displayOverlayInfo(overlayInfo) {
    if (overlayInfo === null)
        return;

    var divFader = document.querySelector('#divFader');
    var divMain = document.querySelector('#divMain');
    var pFull = document.querySelector('#pFull');

    divFader.style.transition = "opacity " + overlayInfo.TransitionDuration + "ms";

    divMain.setAttribute(
        "style",
        "width:" + overlayInfo.Width + "px;" +
        "height: " + overlayInfo.Height + "px"
    );

    divMain.style.backgroundColor = overlayInfo.BackgroundColor;
    divMain.style.color = overlayInfo.FontColor;
    divMain.style.fontSize = overlayInfo.FontSize + "px";
    divMain.style.fontFamily = "'" + overlayInfo.FontFamily + "'";
    divMain.style.borderWidth = overlayInfo.BorderWidth + "px";
    divMain.style.borderColor = overlayInfo.BorderColor;

    pFull.innerHTML = overlayInfo.Prediction.Left;

    divFader.classList.remove('fadeout');
    divFader.classList.add('fadein');

    if (overlayInfo.DisplayDuration > 0) {
        setTimeout(function () {
            divFader.classList.remove('fadein');
            divFader.classList.add("fadeout");
        }, overlayInfo.DisplayDuration);
    }
}

window.addEventListener("beforeunload", function (event) { websocket.close(); });
window.addEventListener("load", init, false);