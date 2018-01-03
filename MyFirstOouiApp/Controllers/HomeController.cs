using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstOouiApp.Models;
using MyFirstOouiApp.Pages;

using Ooui.AspNetCore;
using Xamarin.Forms;

namespace MyFirstOouiApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var page = new MyPage();
            var element = page.GetOouiElement();
            return new ElementResult(element, "Hello from XAML!");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
