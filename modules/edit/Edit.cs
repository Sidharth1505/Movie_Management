using System;
using System.Collections;


namespace Movie_Management
{
    class Edit
    {
        public static void EditMenu()
        {
            label:
            Console.WriteLine("Select the movie from Below List ");
            ArrayList list = View.Display_Only_Names();
            Console.Write("Enter the Name : ");
            string movie_name = Util.GetandCheckInput();
            if (!list.Contains(movie_name.ToLower()))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Movie Not Found !! Please Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                goto label;
            }
            else
            {
                EditDetails.Alter(movie_name);
            }
            
        }

    }
}
