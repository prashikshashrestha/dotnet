using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
        //    //through viewdata
        //    ViewData["Task"] = "Learn dot net";
        //    ViewData["Description"] = "Getting started in Web Development";
        //        ViewData["Status"] = "Done";
        //    //through viewbag
        //    ViewBag.Task1 = "Start Project";
        //    ViewBag.Description1 = "Start TODO List Project";
        //    ViewBag.Status1 = "InProgress";
        //    //through viemodel
        //    var Tasklist = new List<tasklist>
        //    {
        //        new tasklist { task = "Learn dot net", Description = "Starting my journey on webdevelopment", Status= "Done" },
        //        new tasklist { task = "Build a project", Description = "Start a TODO List Project", Status= "InProgress" },
        //        new tasklist { task = "push to Github", Description = "push to github make it publicly available", Status= "ToDo" },

        //    };
            return View(new tasklist());
      

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
