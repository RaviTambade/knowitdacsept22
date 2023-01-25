using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;
using BOL;
using SAL;

namespace TFLStore.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    //Action Method
    [HttpGet]
    public IActionResult Index()
    {
        ProudctHubService svc=new ProudctHubService();
        List<Product> allProducts=svc.GetAllProducts();
        this.ViewData["products"]=allProducts;
        
        return View();
    }

    //http://localhost:7654/products/details/45
    [HttpGet]
    public IActionResult Details(int id)
    {
        return View();
    }

     
}
