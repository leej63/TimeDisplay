using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay.Controllers
{
    public class TimeDisplayController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("index");
        }
    }
}