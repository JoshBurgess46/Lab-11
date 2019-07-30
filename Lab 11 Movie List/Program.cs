using System;
using System.Collections.Generic;

namespace Lab_11_Movie_List
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to Grand Circus Movies! Hit enter to see our categories.\t");
            List<Movies> movieListings = new List<Movies>
                    {
                        new Movies("The Shining", "horror"),
                        new Movies("Paranormal Activity","horror"),
                        new Movies("The Conjuring", "horror"),
                        new Movies("Schindler's List","drama"),
                        new Movies("The Help","drama"),
                        new Movies("The Godfather","drama"),
                        new Movies("The Matrix","scifi"),
                        new Movies("Alien","scifi"),
                        new Movies("Interstellar","scifi"),
                        new Movies("Big Hero 6","animated"),
                        new Movies("Inside Out","animated"),
                        new Movies("Toy Story","animated")
                    };
            bool go = true;
            while (go)
            {




                

                DisplayMenu(movieListings);




            }


        }

        public static void DisplayMenu(List<Movies> movieList)
        {
            Console.WriteLine("\tPick a genre.\t");
            Console.WriteLine();
            Console.WriteLine("\thorror\t");
            Console.WriteLine();
            Console.WriteLine("\tdrama\t");
            Console.WriteLine();
            Console.WriteLine("\tscifi\t");
            Console.WriteLine();
            Console.WriteLine("\tanimated\t");
            Console.WriteLine();
            Console.WriteLine("\tquit\t");
            Console.WriteLine();


            string userInput = Console.ReadLine().ToLower();

            foreach (Movies movie in movieList)
            {

                if (movie.category == userInput)
                {
                    Console.WriteLine(movie.title);

                }
                
                
                
            }
            if (userInput == "quit")
            {
                Console.WriteLine("Stay golden pony boy");
                System.Environment.Exit(0);
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);
        }
    }
}
