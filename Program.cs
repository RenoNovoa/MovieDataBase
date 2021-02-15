using System;
using System.Collections.Generic;

namespace MovieDataBaseLAB11
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            do
            {
                Menu();
                string choice = Console.ReadLine();

                DecisionMaker(choice);

                Console.ReadKey();

            } while (true);
          
        }

        public static void DecisionMaker(string choice)
        {
            if (choice == "1")
            {
                var moviesByCategory = GetMoviesByCategory("Animated");
                DisplayMovieList(moviesByCategory);
            }

            if (choice == "2")
            {
                var moviesByCategory = GetMoviesByCategory("Drama");
                DisplayMovieList(moviesByCategory);
            }

            if (choice == "3")
            {
                var moviesByCategory = GetMoviesByCategory("Horror");
                DisplayMovieList(moviesByCategory);
            }
            if (choice == "4")
            {
                var moviesByCategory = GetMoviesByCategory("Scifi");
                DisplayMovieList(moviesByCategory);
            }
        }

        private static List<Movie> MoviesoftheDay()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("Mr.Fox Running", "Animate"));
            movies.Add(new Movie("The Lego Mov.", "Animate"));
            movies.Add(new Movie("New World", "Drama"));
            movies.Add(new Movie("Michigan Weather", "Drama"));
            movies.Add(new Movie("Chicken Running", "Horror"));
            movies.Add(new Movie("Chicken Running", "Horror"));
            movies.Add(new Movie("Chicken Running", "Scifi"));
            movies.Add(new Movie("Chicken Running", "Scifi"));
            movies.Add(new Movie("Roger Rabbit", "Animate"));
            movies.Add(new Movie("Sonic the hedgehog", "Animate"));


            return movies;
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Movie List Application!\n ");
        }
        public static void Menu()
        {
            Console.WriteLine("Select a category of movies in the fallowing  list:");
            Console.WriteLine("1 - Animated");
            Console.WriteLine("2 - Drama");
            Console.WriteLine("3 - Horror");
            Console.WriteLine("4 - Scifi");
            Console.WriteLine("Enter your choice\nhere SVP: ");
        }

        private static List<Movie> GetMoviesByCategory(string category)
        {
            var movies = MoviesoftheDay();

            List<Movie> moviesByCategory = new List<Movie>();

            foreach (var movie in movies)
            {
                if(movie.Category == category)
                {
                    moviesByCategory.Add(movie);
                }
            }

            return moviesByCategory;
        }

        private static void DisplayMovieList(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.Title);
                Console.WriteLine(movie.Category);
            }
        }
    }

   


    public class Movie
    {
        private string _title;
        private string _category;

        public string Title { get => _title; set => _title = value; }
        public string Category { get => _category; set => _category = value; }


        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }




    }
}
