using Microsoft.AspNetCore.Mvc;

namespace LevelTowAssignment.Controllers
{
    public class HeaderController : Controller
    {
        // GET: HeaderController


        public ActionResult KrakenHeader()
        {
            KrrknHeader header = new KrrknHeader
            {
                Title = "Welcome to Krrkn",
                Subtitle = "Welcome to the Lab"
            };
            return View(header);
        }

    }
}
