using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult QuadrantView()
        {
            ViewBag.Quadrant1 = _repo.TaskData
                .Where(x => x.Quadrant == "Important-Urgent")
                .ToList();
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
                return View("Confirmation");
            }
            else
            {
                return View(response);
            }
            
        }
        public IActionResult Edit(int id)
        {
            //find the matching record in database to edit
            var recordToEdit = _repo.TaskData
                .Single(x => x.TaskID == id);

            //return the add task page
            return View("Update", recordToEdit);
        }
        [HttpPost]
        public IActionResult Edit(TaskData updatedInfo)
        {
            //update the edited record
            _repo.Update(updatedInfo);

            return RedirectToAction("QuadrantView");
        }
        public IActionResult Delete(int id)
        {
            //pull record to Delete
            var recordToDelete = _repo.TaskData
                .Single(x => x.TaskID == id);

            //return Delete page
            return View(recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(TaskData recordToDelete)
        {
            //Delete record
            _repo.Delete(recordToDelete);

            return RedirectToAction("QuadrantView");
        }
    }
}
