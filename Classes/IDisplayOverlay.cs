namespace Aquarius
{
    public abstract class IDisplayOverlay
    {
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

        public IDisplayOverlay()
        {
            BackgroundColor = SettingsManager.Instance.Settings.BackgroundColor;
            FontColor = SettingsManager.Instance.Settings.FontColor;
            FontSize = SettingsManager.Instance.Settings.FontSize;
            FontFamily = SettingsManager.Instance.Settings.FontFamily;
            BorderWidth = SettingsManager.Instance.Settings.BorderWidth;
            BorderColor = SettingsManager.Instance.Settings.BorderColor;
            DisplayDuration = SettingsManager.Instance.Settings.DisplayDuration;
            TransitionDuration = SettingsManager.Instance.Settings.TransitionDuration;
            Width = SettingsManager.Instance.Settings.Width - BorderWidth - BorderWidth;
            Height = SettingsManager.Instance.Settings.Height - BorderWidth - BorderWidth;
        }
    }
}
