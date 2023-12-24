using bellusBibliotheca2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bellusBibliotheca2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}