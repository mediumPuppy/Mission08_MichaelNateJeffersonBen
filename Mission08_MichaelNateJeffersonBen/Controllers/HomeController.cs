using Microsoft.AspNetCore.Mvc;
using Mission08_MichaelNateJeffersonBen.Models;
using System.Diagnostics;

namespace Mission08_MichaelNateJeffersonBen.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
