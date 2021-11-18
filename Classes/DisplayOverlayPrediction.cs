namespace Aquarius
{
    public class DisplayOverlayPrediction : IDisplayOverlay
    {
        public Prediction Prediction { get; set; }

        public DisplayOverlayPrediction()
        {
            Prediction = TwitchManager.Instance.GetCurrentPrediction();
        }
    }
}
