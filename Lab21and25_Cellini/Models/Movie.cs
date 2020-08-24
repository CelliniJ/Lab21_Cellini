using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21and25_Cellini.Models
{
    public class Movie
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public int Year { get; set; }

        public string Actors { get; set; }

        public string Directors { get; set; }

        public Movie()
        {

        }

        public Movie(int ID, string Title, string Genre, int Year, string Actors, string Directors)
        {
            this.ID = ID;
            this.Title = Title;
            this.Genre = Genre;
            this.Year = Year;
            this.Actors = Actors;
            this.Directors = Directors;
        }



    }
}
