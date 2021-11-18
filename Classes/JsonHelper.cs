using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Aquarius
{
    public static class JsonHelper
    {
        private const string FILE_SETTINGS = "settings.json";

        public static Settings LoadSettings()
        {
            Settings settings = null;

            string file = Path.Combine(FILE_SETTINGS);
            if (!File.Exists(file))
                return settings;

            JsonTextReader reader = new JsonTextReader(new StreamReader(file));
            reader.SupportMultipleContent = true;

            JsonSerializer serializer = new JsonSerializer();
            while (true)
            {
                if (!reader.Read())
                    break;

                settings = serializer.Deserialize<Settings>(reader);
            }
            reader.Close();

            return settings;
        }

        public static void SaveSettings(Settings settings)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            using (StreamWriter file = File.CreateText(Path.Combine(FILE_SETTINGS)))
                serializer.Serialize(file, settings);
        }
    }
}
