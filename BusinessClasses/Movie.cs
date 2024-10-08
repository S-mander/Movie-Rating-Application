using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.BusinessClasses
{
    public class Movie
    {             
        private string? title;
		private int year;
		private int rating;
		private string? category;
		

		public Movie()
        {
            title = "";
            year = 0;
			rating = 0;
			category = "";
			
         }

		public Movie(string title, int year, int rating, string category)
		{
			this.Title = title;
			this.Year = year;
			this.Rating = rating;
			this.Category = category;
			
		}

		public string? Title
		{
			get
			{
				return title;
			}
			set
			{
				title = value;
			}
		}

		public int Year
		{
			get
			{
				return year;
			}
			set
			{
				year = value;
			}
		}

        public int Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            }
        }

        public string? Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

		public string GetMovieDisplay(string sep)
		{
			return year + " - " + title + " Rating:" + " - " + rating;
		}


    }
}
