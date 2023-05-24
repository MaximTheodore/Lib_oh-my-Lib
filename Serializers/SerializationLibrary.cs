using Newtonsoft.Json;
namespace Serializer
{
    public class SerializationLibrary
    {
        public static string Serialize<T>(T date, string filename)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = JsonConvert.SerializeObject(date);
            File.WriteAllText(desktop + "\\" + filename +".json", json);
            return json;
        }
        public static T Deserialize<T>(string filename)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = File.ReadAllText(desktop + "\\" + filename + ".json");
            T date = JsonConvert.DeserializeObject<T>(json);
            return date;
        }
    }
}