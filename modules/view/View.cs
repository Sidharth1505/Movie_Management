using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Movie_Management
{
    class View
    {
        public static void Display_All_Movie()
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            var data = Json.GetJsonData();
            foreach (KeyValuePair<string, Dictionary<string, string>> item in data.movies)
            {
                
                Console.WriteLine($"\nMovie Name : {myTI.ToTitleCase(item.Key)}");

                foreach (KeyValuePair<string, string> tmp in item.Value)
                {
                    Console.WriteLine($"{myTI.ToTitleCase(tmp.Key)} :\t {myTI.ToTitleCase(tmp.Value)}");
                }
            }
        }

        public static ArrayList Display_Only_Names()
        {
            var data = Json.GetJsonData();
            ArrayList list_of_movies= new ArrayList();
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            int i = 1;
            foreach(KeyValuePair<string, Dictionary<string, string>> movie in data.movies)
            {
                list_of_movies.Add(movie.Key);
                Console.WriteLine($"{i++}. {myTI.ToTitleCase(movie.Key)}");

            }
            return list_of_movies;
        }

        public static void Display_Specific_Movie(string movie_name)
        {
            var data = Json.GetJsonData();
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            Dictionary<string, string> ls = data.movies[movie_name];
            Console.WriteLine("Stored Details of the Movie is ");
            foreach(KeyValuePair<string, string> item in ls)
            {
                Console.WriteLine($"{myTI.ToTitleCase(item.Key)} : {myTI.ToTitleCase(item.Value)}");
            }
        }
    }
}
