using Movies.BusinessClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Add_Movies
{
    /// <summary>
    /// Interaction logic for AddMovie.xaml
    /// </summary>
    public partial class AddMovie : Window
    {
        private Movie? movie = null;
        public AddMovie()
        {
            InitializeComponent();
        }

        public Movie GetNewMovie()
        {
            this.ShowDialog();
            return movie;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (IsValidData()==true)
            {
                movie = new Movie(txtMovieTitle.Text, Convert.ToInt32(txtYear.Text), 
                    Convert.ToInt32(txtRating.Text), cboCategory.Text);
                this.Close();
            }

        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtMovieTitle.Text, "Title");
            errorMessage += Validator.IsInteger(txtYear.Text, "Year");
            errorMessage += Validator.IsInteger(txtRating.Text, "Rating");
            errorMessage += Validator.IsPresent(cboCategory.Text, "Title");

            if (errorMessage != "" || Convert.ToInt32(txtRating.Text) < 1 || Convert.ToInt32(txtRating.Text) > 10)
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
