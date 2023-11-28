using HttpClientFactory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HttpClientFactory.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}