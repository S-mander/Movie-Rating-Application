using Movies.BusinessClasses;
using Movies.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Add_Movies
{
    /// <summary>
    /// Interaction logic for MyMovieReviews.xaml
    /// </summary>
    public partial class MyMovieReviews : Window
    {
        private List<Movie> movies = null;
        public MyMovieReviews()
        {
            movies = MovieDB.GetMovieReviews();

            InitializeComponent();
        }
        private void FillMovieListBox()
        {
            foreach (Movie m in movies)
            {
                lstMovies.Items.Add(m.GetMovieDisplay("\t"));
            }
        }

        private void btnAddMovie_Click(object sender, RoutedEventArgs e)
        {
            AddMovie NewMovieForm = new AddMovie();
            Movie movie = NewMovieForm.GetNewMovie();
            if (movie != null)
            {
                movies.Add(movie);
                MovieDB.SaveMovieReviews(movies);
                FillMovieListBox();
            }

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void btnDeleteMovie_Click(object sender, RoutedEventArgs e)
        {
            int i = lstMovies.SelectedIndex;
            if (i != -1)
            {
                Movie movie = (Movie)movies[i];
                string message = "Are you sure you would like to delete " + movie.Title + " ?";
                MessageBoxResult button =
                    MessageBox.Show(message, "Confirm this delete action ", MessageBoxButton.YesNo);
                if (button == MessageBoxResult.Yes)
                {
                    movies.Remove(movie);
                    MovieDB.SaveMovieReviews(movies);
                    FillMovieListBox();
                }
            }

        }
    }
}
