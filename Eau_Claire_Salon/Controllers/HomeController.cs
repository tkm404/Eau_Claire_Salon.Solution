using Microsoft.AspNetCore.Mvc;

namespace Eau_Claire_Salon.Controllers
{
    public class HomeController : Controller
{

    [HttpGet("/")]
    public ActionResult Index()
    {
        return View();
    }

}
}