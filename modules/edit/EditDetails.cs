using System;
using System.Collections.Generic;


namespace Movie_Management
{
    class EditDetails
    {
        public static void Alter(string movie_name)
        {
            var data = Json.GetJsonData();
            View.Display_Specific_Movie(movie_name);

            Console.WriteLine("\nEnter 1 to alter director name ");
            Console.WriteLine("Enter 2 to alter duration ");
            Console.WriteLine("Enter 3 to alter actor ");
            Console.WriteLine("Enter 4 to alter genre ");

            string tmp = Console.ReadLine();
            int choice = 0;
            try
            {
                choice = Int32.Parse(tmp);

            }
            catch
            {
                Util.DisplayError("Enter numerice Value Only");
            }
            switch (choice)
            {
                case 1:
                    Console.Write("Enter name of director : ");
                    string corrected_director = Util.GetandCheckInput();
                    data.movies[movie_name]["director"] = corrected_director;
                    break;
                case 2:
                    Console.Write("Enter name of duration : ");
                    string corrected_duration = Util.GetandCheckInput();
                    data.movies[movie_name]["duration"] = corrected_duration;
                    break;
                case 3:
                    Console.Write("Enter name of actor : ");
                    string corrected_actor = Util.GetandCheckInput();
                    data.movies[movie_name]["actor"] = corrected_actor;
                    break;
                case 4:
                    Console.Write("Enter name of genre:  ");
                    string corrected_genre = Util.GetandCheckInput();
                    data.movies[movie_name]["genre"] = corrected_genre;
                    break;
                default:
                    Util.DisplayError("Enter the correct choice : ");
                    break;
            }

            Json.WriteToJson(data);

        }
    }
}
