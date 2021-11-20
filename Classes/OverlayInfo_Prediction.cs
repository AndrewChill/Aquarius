namespace Aquarius
{
    // The Prediction version of the OverlayInfo includes one extra property, the Prediction object.
    // This object contains all of the info about the prediction if you're willing to dig into it in JavaScript,
    // or you can use one of the helper properties that are pre-built to parse and format the data.
    public class DisplayOverlay_Prediction : IOverlayInfo
    {
        public Prediction Prediction { get; set; }

        public DisplayOverlay_Prediction()
        {
            Prediction = TwitchManager.Instance.GetCurrentPrediction();
        }
    }
}
