
namespace MovieTutorial.MovieDB.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.StateCountryRow))]
    public class StateCountryController : Controller
    {
        [Route("MovieDB/StateCountry")]
        public ActionResult Index()
        {
            return View("~/Modules/MovieDB/StateCountry/StateCountryIndex.cshtml");
        }
    }
}