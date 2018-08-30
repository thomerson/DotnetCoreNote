using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotnetCore.Web.Models;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetCore.Web.Controllers
{
    public class HomeController : Controller
    {
        ServiceCollection services = new ServiceCollection();
        public IActionResult Index()
        {
            var result = JsonConfiguration.GetAppSettings<Logging>("Logging");

            //this.HttpContext.RequestServices
            var provider = services.BuildServiceProvider();
            var singletone1 = provider.GetService<ILog>();
            singletone1.Write("");

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
