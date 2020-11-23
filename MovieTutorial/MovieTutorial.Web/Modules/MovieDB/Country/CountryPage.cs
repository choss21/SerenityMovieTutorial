
namespace MovieTutorial.MovieDB.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.CountryRow))]
    public class CountryController : Controller
    {
        [Route("MovieDB/Country")]
        public ActionResult Index()
        {
            return View("~/Modules/MovieDB/Country/CountryIndex.cshtml");
        }
    }
}