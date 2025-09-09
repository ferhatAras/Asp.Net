using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Asp.net.Models;

namespace Asp.net.Controllers;

public class HomeController : Controller
{
 
    public string Index()
    {
        return "home/index";
    }

    public string Contact()
    {
      return "home/contact";   
    }
    
}
