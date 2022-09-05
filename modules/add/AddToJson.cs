using System;
using System.Collections.Generic;


namespace Movie_Management
{
    class AddToJson
    {
        public static void AddData(string movie_name, Dictionary<string , string>movie_details)
        {
            var data = Json.GetJsonData();
            data.movies.Add(movie_name, movie_details);
            Json.WriteToJson(data);
            Util.DisplaySuccess("Succesfully Added");
        }
    }
}
