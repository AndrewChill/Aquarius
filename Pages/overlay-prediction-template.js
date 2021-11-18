
// We want the user to be able to specify the port number for their web socket to run on,
// but we don't have a good way to modify this static js file. So, we use this file as
// a template, and when running the app, this template file is copied to 'overlay-prediction.js'
// and the {PORT_NUMBER} value is replaced with the port number specified by the user.

var wsUri = "ws://localhost:{PORT_NUMBER}/socket/overlay-prediction/";

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

    if (message.startsWith("{DISPLAY_OVERLAY}")) {
        message = message.replace("{DISPLAY_OVERLAY}", "");
        var value = JSON.parse(message);
        setDisplayOverlay(value)
    }
}

function setDisplayOverlay(displayOverlay) {
    if (displayOverlay === null)
        return;

    var divPredictionTrans = document.querySelector('#divPredictionTrans');
    var divPrediction = document.querySelector('#divPrediction');
    var pPrediction = document.querySelector('#pPrediction');

    divPredictionTrans.style.transition = "opacity " + displayOverlay.TransitionDuration + "ms";

    divPrediction.setAttribute(
        "style",
        "width:" + displayOverlay.Width + "px;" +
        "height: " + displayOverlay.Height + "px"
    );

    divPrediction.style.backgroundColor = displayOverlay.BackgroundColor;
    divPrediction.style.color = displayOverlay.FontColor;
    divPrediction.style.fontSize = displayOverlay.FontSize + "px";
    divPrediction.style.fontFamily = "'" + displayOverlay.FontFamily + "'";
    divPrediction.style.borderWidth = displayOverlay.BorderWidth + "px";
    divPrediction.style.borderColor = displayOverlay.BorderColor;

    pPrediction.innerHTML = displayOverlay.Prediction.Summary;

    divPredictionTrans.classList.remove('fadeout');
    divPredictionTrans.classList.add('fadein');

    if (displayOverlay.DisplayDuration > 0) {
        setTimeout(function () {
            divPredictionTrans.classList.remove('fadein');
            divPredictionTrans.classList.add("fadeout");
        }, displayOverlay.DisplayDuration);
    }
}

window.addEventListener("beforeunload", function (event) { websocket.close(); });
window.addEventListener("load", init, false);