namespace Aquarius
{
    // We could have many different types of panels (prediction, reward, subscription) but all of them should inherit from this
    // interface, because we can define all of the basic characteristics of a panel here so that they'll all work the same.
    public abstract class IOverlayInfo
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

        public IOverlayInfo()
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
