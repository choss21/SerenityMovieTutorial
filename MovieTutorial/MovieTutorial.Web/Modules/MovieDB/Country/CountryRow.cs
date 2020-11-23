
namespace MovieTutorial.MovieDB.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("MovieDB"), TableName("[dbo].[Countries]")]
    [DisplayName("Paises"), InstanceName("Country")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    //[LookupScript]
    public sealed class CountryRow : Row, IIdRow, INameRow
    {
        [DisplayName("Country Id"), Identity]
        public Int32? CountryId
        {
            get { return Fields.CountryId[this]; }
            set { Fields.CountryId[this] = value; }
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CountryId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CountryRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CountryId;
            public StringField Name;
        }
    }
}
