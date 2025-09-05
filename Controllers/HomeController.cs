using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Asp.net.Models;

namespace Asp.net.Controllers;

public class HomeController : Controller
{
 
    public IActionResult Index()
    {
        return View();
    }

    public string Contact()
    {
        return "Home/Contact";
    }
    
}
