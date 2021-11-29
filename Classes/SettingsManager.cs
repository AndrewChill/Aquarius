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
            _Settings = JsonHelper.Parse<Settings>(FILE_SETTINGS);

            if (_Settings == null)
                SaveSettings(new Settings());
        }

        public void SaveSettings(Settings settings)
        {
            JsonHelper.Save(settings, FILE_SETTINGS);
            _Settings = settings;
        }

        // The file in the execution directory where settings will be stored.
        private const string FILE_SETTINGS = "settings.json";

        public Settings Settings { get { return _Settings == null ? new Settings() : _Settings; } }
    }
}
