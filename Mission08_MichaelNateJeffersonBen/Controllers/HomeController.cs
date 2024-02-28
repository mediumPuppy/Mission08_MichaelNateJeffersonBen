using Microsoft.AspNetCore.Mvc;
using Mission08_MichaelNateJeffersonBen.Models;
using System.Diagnostics;

namespace Mission08_MichaelNateJeffersonBen.Controllers
{
    public class HomeController : Controller
    {
        private ITaskRepository _repo;

        public HomeController(ITaskRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View(new TaskData());
        }
        [HttpPost]
        public IActionResult Update(TaskData response)
        {
            if (ModelState.IsValid)
            {
                //Add record to the database and save it
                _repo.AddTask(response);
            }
            return View("Confirmation");
        }
    }
}
