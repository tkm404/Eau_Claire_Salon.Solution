using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class StylistController : Controller
{

    [HttpGet("/")]
    public ActionResult Index()
    {
        return View();
    }

}
}