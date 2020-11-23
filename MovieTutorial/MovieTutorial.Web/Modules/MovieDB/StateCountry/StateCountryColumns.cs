
namespace MovieTutorial.MovieDB.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MovieDB.StateCountry")]
    [BasedOnRow(typeof(Entities.StateCountryRow), CheckNames = true)]
    public class StateCountryColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 StateCountryId { get; set; }
        [EditLink]
        public String Name { get; set; }
        public String CountryName { get; set; }
    }
}