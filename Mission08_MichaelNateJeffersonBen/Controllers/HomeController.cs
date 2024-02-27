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

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Update(Model response) 
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //Add record to the database and save it
        //        _context.Model.Add(response);
        //        _context.SaveChanges();

        //        return View("Confirmation");
        //    }
        //    else
        //    {
        //        ViewBag.Blah = _context.Blah
        //        .OrderBy(x => x.Category)
        //        .ToList();
        //        return View(response);
        //    }
        //}
    }
}
