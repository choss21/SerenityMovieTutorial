
namespace MovieTutorial.MovieDB.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("MovieDB"), TableName("[dbo].[StatesCountry]")]
    [DisplayName("Estados"), InstanceName("State Country")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")] 
    [LookupScript]
    public sealed class StateCountryRow : Row<StateCountryRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("State Country Id"), Identity, IdProperty]
        public Int32? StateCountryId
        {
            get { return Fields.StateCountryId[this]; }
            set { Fields.StateCountryId[this] = value; }
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch, NameProperty]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Country"), NotNull, ForeignKey("[dbo].[Countries]", "CountryId"), LeftJoin("jCountry"), TextualField("CountryName")]
        [LookupEditor(typeof(CountryRow)),LookupInclude]
        public Int32? CountryId
        {
            get { return Fields.CountryId[this]; }
            set { Fields.CountryId[this] = value; }
        }

        [DisplayName("Country Name"), Expression("jCountry.[Name]")]
        public String CountryName
        {
            get { return Fields.CountryName[this]; }
            set { Fields.CountryName[this] = value; }
        }
        public StateCountryRow()
        {
        }

        public StateCountryRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field StateCountryId;
            public StringField Name;
            public Int32Field CountryId;

            public StringField CountryName;
        }
    }
}
