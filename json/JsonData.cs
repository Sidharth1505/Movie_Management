using System;
using System.Collections.Generic;


namespace Movie_Management
{
    public class JsonData
    {
        public Dictionary<string, Dictionary<string, string>> movies;
        public JsonData()
        {
            movies = new Dictionary<string, Dictionary<string, string>>();
        }

    }
}
