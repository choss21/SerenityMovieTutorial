
namespace MovieTutorial.MovieDB.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow), CheckNames = true)]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MovieId { get; set; }
        [EditLink]
        public String Title { get; set; }
        [EditLink, Width(300)]
        public String Description { get; set; }
        public String Storyline { get; set; }
        [Width(70)]
        public Int32 Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        [DisplayName("Min")]
        public Int32 Runtime { get; set; }
    }
}