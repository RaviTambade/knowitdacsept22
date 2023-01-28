using Microsoft.AspNetCore.Mvc;
using BOL;

namespace CatalogService.Controllers;

[ApiController]
[Route("[controller]")]  //attribute routing

public class ProductsController : ControllerBase
{
    
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult GetProducts(){
        var products=new List<Product> ();    
        products.Add(new Product{ Id=1, Title="Gerbera",  Description="Wedding flower", UnitPrice=5, Quantity=4000 });
        products.Add(new Product{ Id=2, Title="Rose",  Description="Valentine flower", UnitPrice=12, Quantity=16000 });
        return Ok(products);
    }
    

    [Route("{id}")]
    [HttpGet]
    public IActionResult GetProductById(int id){
        Console.WriteLine("Id= "+ id);
        Product theProduct=new Product{ Id=1, Title="Jasmine",  Description="Fregrance flower", UnitPrice=1, Quantity=4000 };
        return Ok(theProduct);
    }

    [Route("{id}")]
    [HttpDelete]
    public IActionResult DeleteProductById(int id){
        Console.WriteLine(" Product to be DeleteId= "+ id);
        return Ok("Product is removed from catalog");
    }

     [HttpPost]
    public IActionResult Insert(Product p){

        Console.WriteLine("Title= "+ p.Title + " , Description= "+p.Description);
        //insertion logic for pushing new object into collection.

        return Ok("Produt is inserted");
    }
    

    [Route("{id}")]
    [HttpPut]
    public IActionResult Update(int id,Product p){
        
        Console.WriteLine("Title= "+ p.Title + " , Description= "+p.Description);
        //updation logic for into collection.

        return Ok("Existing Produt is updated....");
    }

}
