namespace Aquarius
{
    public class Settings
    {
        public string TwitchChannel { get; set; }
        public string TwitchToken { get; set; }
        public string TwitchClientId { get; set; }
        public int PortNumber { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string BackgroundColor { get; set; }
        public string FontColor { get; set; }
        public int FontSize { get; set; }
        public string FontFamily { get; set; }
        public int BorderWidth { get; set; }
        public string BorderColor { get; set; }
        public int DisplayDuration { get; set; }
        public int TransitionDuration { get; set; }
        public bool RefreshOnLoad { get; set; }
        public bool RefreshOnTimer { get; set; }
        public int RefreshTimerDuration { get; set; }
    }
}