using MovieTutorial.MovieDB.Entities;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;
using System.Collections.Generic;
using System.Linq;

namespace MovieTutorial.MovieDB.Lookups
{
    [LookupScript]
    public class CountryLookup : RowLookupScript<Entities.CountryRow>
    {
        public CountryLookup()
        {

        }
        protected override List<CountryRow> GetItems()
        {
            var items = base.GetItems();
            items = items.OrderBy(x => x.CountryId).ToList();

            items.Insert(0, new CountryRow()
            {
                CountryId = -1,
                Name = "Ninguno Seleccionado"
            });
            return items;
        }
    }
}
