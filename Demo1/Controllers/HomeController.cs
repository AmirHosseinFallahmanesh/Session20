using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo1.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Demo1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          
            return View();
        }

        public IActionResult SetSession(string name)
        {
            HttpContext.Session.SetObject<string>("k1", "test");
            
            return RedirectToAction("index");
        }

      
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    
    }
}
