using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationnew.Models;

namespace WebApplicationnew.Controllers
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
            _logger.LogInformation($"First information");
            _logger.LogInformation($"Second infomation");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Exception()
        {
            try
            {
               throw  new NotImplementedException();

            }
            catch (Exception e)
            {

                _logger.LogError($" Exception Handled {e.Message}");
            }
                       return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
