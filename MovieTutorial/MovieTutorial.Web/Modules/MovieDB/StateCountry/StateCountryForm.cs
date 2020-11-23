
namespace MovieTutorial.MovieDB.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MovieDB.StateCountry")]
    [BasedOnRow(typeof(Entities.StateCountryRow), CheckNames = true)]
    public class StateCountryForm
    {
        public String Name { get; set; }
        public Int32 CountryId { get; set; }
    }
}