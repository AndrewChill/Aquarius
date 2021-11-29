using Newtonsoft.Json;
using System.IO;

namespace Aquarius
{
    public static class JsonHelper
    {
        public static T Parse<T>(string path)
        {
            T value = default(T);

            if (!File.Exists(path))
                return value;

            JsonTextReader reader = new JsonTextReader(new StreamReader(path));
            reader.SupportMultipleContent = true;

            JsonSerializer serializer = new JsonSerializer();
            while (true)
            {
                if (!reader.Read())
                    break;

                value = serializer.Deserialize<T>(reader);
            }
            reader.Close();

            return value;
        }

        public static void Save<T>(T value, string path)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            using (StreamWriter file = File.CreateText(Path.Combine(path)))
                serializer.Serialize(file, value);
        }
    }
}
