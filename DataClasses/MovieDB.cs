using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.BusinessClasses;

namespace Movies.DataClasses
{
    public static class MovieDB
    {
        private const string dir = @"..\..\..\DataStore\";
        private const string path = dir + "Movies.txt";

        public static List<Movie> GetMovieReviews()
        {
            StreamReader textIn =
                new StreamReader(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            
            List<Movie> movies = new List<Movie>();

           
            while (textIn.Peek() != -1)
            {
                string? row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Movie movie = new Movie();
                movie.Title = columns[0];
                movie.Year = Convert.ToInt32(columns[1]);
                movie.Rating = Convert.ToInt32(columns[2]);
                movie.Category = columns[3];
                movies.Add(movie);
            }

            textIn.Close();

            return movies;
        }

        public static void SaveMovieReviews(List<Movie> movies)
        {
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach (Movie movie in movies)
            {
                textOut.Write(movie.Title + "|");
                textOut.Write(movie.Year + "|");
                textOut.Write(movie.Rating + "|");
                textOut.WriteLine(movie.Category);
            }

            textOut.Close();
        }

    }
}
