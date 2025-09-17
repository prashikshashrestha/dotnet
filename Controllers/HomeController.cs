using Azure.Core;
using db.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using todo.Data;
using todo.Models;

namespace todo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        // Inject both logger and ApplicationDbContext
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            if (Request.Method == "POST")
            {
                var tlist = new TaskList
                {
                    task = Request.Form["task"],
                    Description = Request.Form["description"],
                    Status = Request.Form["status"]
                };

                _context.TaskList.Add(tlist);
                _context.SaveChanges();

                Console.WriteLine($"Form Submitted: Task={tlist.task}, Description={tlist.Description}, Status={tlist.Status}");
            }
            var tasklist = _context.TaskList.ToList();
            return View(tasklist);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
