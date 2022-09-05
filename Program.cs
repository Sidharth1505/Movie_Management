using System;

namespace Movie_Management
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to Movie Management System\n");

            while (true) {
                Console.WriteLine("\nEnter 1 to Add a Movie");
                Console.WriteLine("Enter 2 to View the Movie Details");
                Console.WriteLine("Enter 3 to Edit Movie Detail");
                Console.WriteLine("Enter 4 to Exit");
                Console.Write("Enter your Choice : ");
                string tmp = Console.ReadLine();
                int choice = 0;
                try
                {
                    choice = Int32.Parse(tmp);
                    switch (choice)
                    {
                        case 1:
                            Add.Add_Movie();
                            break;

                        case 2:
                            View.Display_All_Movie();
                            break;

                        case 3:
                            Edit.EditMenu();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Util.DisplayError("Enter a Valid Choice");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Util.DisplayError("Please Enter numerice value only");
                }
            }
        }
    }
}
