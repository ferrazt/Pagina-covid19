using COVID.Interface;
using COVID.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace COVID.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITB_COVID_01 _TB01;
        private readonly ILogger<HomeController> _logger;

        public HomeController(
            ITB_COVID_01 TB01
            
            )
        {
            _TB01 = TB01;
            
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {

            var model = new HomeViewModel 
            { 
                TB01 = _TB01.Listar() 
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        

        public class HomeViewModel
        {
            public HomeViewModel()
            {
                TB01 = new List<TB_COVID_01>();
            }
            public IEnumerable<TB_COVID_01> TB01 { get; set; }
        }
    }
}
