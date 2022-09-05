using System;
using System.Collections.Generic;

namespace Movie_Management
{
    class Add
    {
        public static void Add_Movie()
        {
            Console.WriteLine("\nEnter the details of the movie you have recently watched ");
            string movie_name;
            Dictionary<string, string> movie_details = new Dictionary<string, string>();
            while (true)
            {
                try
                {
                    Console.Write("\nEnter the name of the movie : ");
                    movie_name = Console.ReadLine().ToLower();

                    if (movie_name == "") throw new FormatException();
                }
                catch
                {
                    Util.DisplayError("Enter a Valid Name");
                    continue;
                }
                break;
                
            }

            Console.Write("\nEnter the director of the movie : ");
            string director = Util.GetandCheckInput();
            movie_details.Add("director", director);

            Console.Write("\nEnter the duration of the movie : ");
            string duration = Util.GetandCheckInput();
            movie_details.Add("duration", duration);

            Console.Write("\nEnter the actor of the movie :");
            string  actor= Util.GetandCheckInput();
            movie_details.Add("actor", actor);

            Console.Write("\nEnter the genre of the movie : ");
            string genre = Util.GetandCheckInput();
            movie_details.Add("genre", genre);

            AddToJson.AddData(movie_name, movie_details);
        }
        
        
    }

    
}
