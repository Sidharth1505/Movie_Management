using System;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;



namespace Movie_Management
{
    
    class Json
    {
        public static JsonData GetJsonData()
        { 
            string jsonString = File.ReadAllText("../../movie.json");
                JsonData jsondata = JsonConvert.DeserializeObject<JsonData>(jsonString);
                return jsondata;
        
        }

        public static void WriteToJson(JsonData jsondata)
        {
            var serializedData = JsonConvert.SerializeObject(jsondata);
            File.WriteAllText("../../movie.json", serializedData);
        }
    }
}
