using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;
using BOL;
using SAL;

namespace TFLStore.Controllers;

public class ShoppingCartController : Controller
{
    private readonly ILogger<ShoppingCartController> _logger;

    public ShoppingCartController(ILogger<ShoppingCartController> logger)
    {
        _logger = logger;
    }

    //Action Method
    [HttpGet]
    public IActionResult Index()
    {
        //Show list of items kept in cart maintained by session
        int cart=int.Parse(HttpContext.Session.GetInt32("cart").ToString());

        this.ViewData["cart"]=cart;
        Console.WriteLine("DATA IS retrived from session cart");
        Console.WriteLine(cart);
        return View();
    }

     [HttpGet]
    public IActionResult AddToCart(int id)
    {
        //Add new item in existing cart maintained by session
        Console.WriteLine("DATA IS ADDED to session cart");
        HttpContext.Session.SetInt32("cart", id);

        return RedirectToAction("Index","ShoppingCart");
    }

    [HttpGet]
    public IActionResult RemoveFromCart()
    {
        //Add the item from existing cart maintained by session

             return View();
    }

     
     
}
