
namespace MovieTutorial.MovieDB.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("MovieDB"), TableName("[dbo].[Movie]")]
    [DisplayName("Peliculas"), InstanceName("Pelicula")]
    [ReadPermission("Movie:General")]
    [ModifyPermission("Movie:General")]
    public sealed class MovieRow : Row<MovieRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Movie Id"), Identity, IdProperty]
        public Int32? MovieId
        {
            get { return Fields.MovieId[this]; }
            set { Fields.MovieId[this] = value; }
        }

        [DisplayName("Titulo"), Size(200), NotNull, QuickSearch(SearchType.Contains), NameProperty]
        public String Title
        {
            get { return Fields.Title[this]; }
            set { Fields.Title[this] = value; }
        }

        [DisplayName("Descripción"), Size(1000), QuickSearch(SearchType.Contains)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Historia")]
        public String Storyline
        {
            get { return Fields.Storyline[this]; }
            set { Fields.Storyline[this] = value; }
        }

        [DisplayName("Año"), QuickSearch(SearchType.Equals, numericOnly: 1)]
        public Int32? Year
        {
            get { return Fields.Year[this]; }
            set { Fields.Year[this] = value; }
        }

        [DisplayName("Fecha Lanzamiento"), QuickFilter]
        public DateTime? ReleaseDate
        {
            get { return Fields.ReleaseDate[this]; }
            set { Fields.ReleaseDate[this] = value; }
        }

        [DisplayName("Duracion (Min)")]
        public Int32? Runtime
        {
            get { return Fields.Runtime[this]; }
            set { Fields.Runtime[this] = value; }
        }

        [DisplayName("Tipo"), NotNull, QuickFilter, QuickFilterOption("multiple", "true")]
        public MovieKind? Kind
        {
            get { return (MovieKind?)Fields.Kind[this]; }
            set { Fields.Kind[this] = (Int32?)value; }
        }
        //                                  NombreTabla  IdVincula con tabla Genre
        [DisplayName("Genero"), ForeignKey("Genre", "GenreId"), LeftJoin("g")]
        [LookupEditor(typeof(GenreRow), InplaceAdd = false), QuickFilter, QuickFilterOption("multiple", "true")]
        public Int32? GenreId
        {
            get { return Fields.GenreId[this]; }
            set { Fields.GenreId[this] = value; }
        }

        [DisplayName("Nombre Genero"), Expression("g.Name")]
        public String GenreName
        {
            get { return Fields.GenreName[this]; }
            set { Fields.GenreName[this] = value; }
        }
        [DisplayName("Pais"), ForeignKey("Countries", "CountryId"), LeftJoin("jCountry")]
        [LookupEditor(typeof(CountryRow)),QuickFilter]
        public int? CountryId
        {
            get { return Fields.CountryId[this]; }
            set { Fields.CountryId[this] = value; }
        }
        [DisplayName("Nombre Pais"), Expression("jCountry.Name")]
        public String CountryName
        {
            get { return Fields.CountryName[this]; }
            set { Fields.CountryName[this] = value; }
        }

        [DisplayName("Estado"), ForeignKey("StatesCountry", "StateCountryId"), LeftJoin("jStateCountry")]
        [LookupEditor(typeof(StateCountryRow),CascadeFrom ="CountryId", CascadeField ="CountryId"),QuickFilter]
        public int? StateCountryId
        {
            get { return Fields.StateCountryId[this]; }
            set { Fields.StateCountryId[this] = value; }
        }
        [DisplayName("Nombre Estado"), Expression("jStateCountry.Name")]
        public String StateCountryName
        {
            get { return Fields.StateCountryName[this]; }
            set { Fields.StateCountryName[this] = value; }
        }



        [NotMapped]
        public String TitleUpper
        {
            get { return Fields.TitleUpper[this]; }
            set { Fields.TitleUpper[this] = value; }
        }
        public MovieRow()
        {
        }

        public MovieRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieId;
            public StringField Title;
            public StringField Description;
            public StringField Storyline;
            public Int32Field Year;
            public DateTimeField ReleaseDate;
            public Int32Field Runtime;
            public Int32Field Kind;
            public StringField TitleUpper;

            public Int32Field GenreId;
            public StringField GenreName;

            public Int32Field CountryId;
            public StringField CountryName;

            public Int32Field StateCountryId;
            public StringField StateCountryName;
        }
    }
}
