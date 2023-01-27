using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BIAPP.Models;

namespace BIAPP.Controllers;

public class HomeController : Controller
{


    


    string myData="Transflower";
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        this.myData="seed";
        return View();
    }

    public IActionResult Privacy()
    {

        this.myData="KnowIT";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
