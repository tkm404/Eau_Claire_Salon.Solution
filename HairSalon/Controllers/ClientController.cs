using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class ClientController : Controller
{

  public ActionResult Index()
    {
        return View();
    }

}
}