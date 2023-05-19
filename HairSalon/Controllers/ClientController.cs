using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
    public class ClientController : Controller
{
    private readonly HairSalonContext _db;

    public ClientController(HairSalonContext db)
    {
        _db = db;
    }

  public ActionResult Index()
    {
        List<Client> model = _db.Clients.ToList();
        return View(model);
    }

}
}