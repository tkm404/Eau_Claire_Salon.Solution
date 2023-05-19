using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class StylistController : Controller
{

  public ActionResult Index()
    {
        return View();
    }

}
}