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
        Console.WriteLine("Product Count " +allProducts.Count);
       // this.ViewData["products"]=allProducts;
        this.ViewBag.catalog=allProducts; 
        TempData["dataFromIndex"]="This is data from Index view of Products";
        return View();
    }

    //http://localhost:7654/products/details/45
    [HttpGet]
    public IActionResult Details(int id)
    {  
        ProudctHubService svc=new ProudctHubService();
        Product product=svc.GetProductById(id);  
        Console.WriteLine(product.Title + " " + product.ProductId);
        
        ViewBag.currentProduct=product;
        return View();
    }

     
}
