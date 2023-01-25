using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;

namespace TFLStore.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
         Console.WriteLine("Account constructor is invoked....");
      

        _logger = logger;
    }

    //Action Method
    [HttpGet]
    public IActionResult Login()
    {
        Console.WriteLine("GET type  of Login action method");
        return View();
       //return null;
    }


    [HttpPost]
    public IActionResult Login(string email, string password)
    {
          Console.WriteLine("POST type  of Login action method");
        if(email =="ravi.tambade@transflower.in" && password=="seed123"){
            Response.Redirect("/orders/index");
        }
        //
        return View();
    }

     //Action Method
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Register(string firstname, string lastname, string  location,string email, string password)
    {
        Console.WriteLine(firstname + " " + lastname + " "+ location);
        return this.RedirectToAction("Login","Account");
    }
}
