using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Linq;

namespace HairSalon.Controllers
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