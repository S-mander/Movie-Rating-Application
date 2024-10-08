-Movie Rating App

This is a C# WPF application that allows users to add, rate, and delete movies. The app supports persistent storage of movie reviews 
using a text file and features two windows: one for adding/deleting movies and another for displaying the list of movie reviews.

Features
  Add Movie: Input movie title, year, rating (1-10), and category.
  Delete Movie: Select a movie from the list to remove.
  View Movie List: Displays all movies along with their rating and release year.
  Data Persistence: Movie reviews are saved to a text file for later use.

Key Components
  Movie Class: Represents each movie with properties for title, year, rating, and category.
  Validator Class: Ensures valid data entry (e.g., non-empty fields, integer values for year and rating).
  MovieDB Class: Handles reading from and writing to the text file that stores movie data.
  AddMovie Window: User interface for adding new movies.
  MyMovieReviews Window: User interface for viewing and deleting movies.

How to Use
  Add a Movie: Open the "Add Movie" window, fill in the movie details, and save.
  Delete a Movie: Select a movie from the list and confirm deletion.
  View Movies: Movies will automatically be loaded and saved from/to Movies.txt.
