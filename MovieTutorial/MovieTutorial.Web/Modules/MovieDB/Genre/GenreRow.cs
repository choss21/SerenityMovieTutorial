
namespace MovieTutorial.MovieDB.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("MovieDB"), TableName("[dbo].[Genre]")]
    [DisplayName("Generos"), InstanceName("Genero")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class GenreRow : Row<GenreRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Genre Id"), Identity, IdProperty]
        public Int32? GenreId
        {
            get { return Fields.GenreId[this]; }
            set { Fields.GenreId[this] = value; }
        }

        [DisplayName("Nombre"), Size(100), NotNull, QuickSearch, NameProperty]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }
        public GenreRow()
        {
        }

        public GenreRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field GenreId;
            public StringField Name;
        }
    }
}
