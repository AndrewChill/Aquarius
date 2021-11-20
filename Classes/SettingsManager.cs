namespace Aquarius
{
    public class SettingsManager
    {
        #region Instance
        private static SettingsManager _Instance;
        private static Settings _Settings { get; set; }

        public static SettingsManager Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new SettingsManager();
                return _Instance;
            }
        }
        #endregion Instance

        public SettingsManager()
        {
            LoadSettings();
        }

        public void LoadSettings()
        {
            _Settings = JsonHelper.LoadSettings();
        }

        public void SaveSettings(Settings settings)
        {
            JsonHelper.SaveSettings(settings);
            _Settings = settings;
        }

        public Settings Settings { get { return _Settings == null ? new Settings() : _Settings; } }
    }
}
