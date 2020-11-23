
namespace MovieTutorial.MovieDB.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using MovieTutorial.MovieDB.Entities;

    [FormScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow), CheckNames = true)]
    public class MovieForm
    {
        [DisplayName("Titulo de la pelicula")]
        public String Title { get; set; }
        [ReadOnly(true)]
        public String TitleUpper { get; set; }
        public int CountryId { get; set; }
        public int StateCountryId { get; set; }       
        public MovieKind Kind { get; set; }
        [LookupEditor(typeof(GenreRow), InplaceAdd = true)]
        public int GenreId { get; set; }
        [TextAreaEditor(Rows = 3)]
        public String Description { get; set; }
        [TextAreaEditor(Rows = 8)]
        public String Storyline { get; set; }
        [HalfWidth]
        public Int32 Year { get; set; }
        [HalfWidth]
        public DateTime ReleaseDate { get; set; }
        public Int32 Runtime { get; set; }
    }
}