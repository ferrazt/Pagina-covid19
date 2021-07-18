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
        
        private readonly IVW02_COVID_ONLINE _VW02;
        private readonly IVW01_COVID_UF _VW01_UF;

        public HomeController(
           
            IVW02_COVID_ONLINE VW02,
            IVW01_COVID_UF VW01_UF


            )
        {
            
            _VW02 = VW02;
            _VW01_UF = VW01_UF;
            
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            DateTime localDate = DateTime.Now;
            var dataOntem = localDate.AddDays(-3);
            



            var model = new HomeViewModel 
            { 
                
                VW02_COVID_ONLINE = _VW02.Listar(),
                VW01_COVID_UF = _VW01_UF.Listar()
            };
            ViewBag.dataOntem = dataOntem;
            ViewBag.DataHoje = localDate;
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
                
                VW02_COVID_ONLINE = new List<VW02_COVID_ONLINE>();
                VW01_COVID_UF = new List<VW01_COVID_UF>();
            }
            
            public IEnumerable<VW02_COVID_ONLINE> VW02_COVID_ONLINE { get; set; }
            public IEnumerable<VW01_COVID_UF> VW01_COVID_UF { get; set; }
        }
    }
}
