namespace SAL;
using BOL;
using BLL;

public class ProudctHubService
{
    public List<Product> GetAllProducts(){
        ProductManager theManager=ProductManager.GetProductManager();
        List<Product> allProducts=theManager.GetAllProducts();
        return allProducts;
         
    }

    public Product GetProductById(int id){
        ProductManager theManager=ProductManager.GetProductManager();
        Product  theProduct=theManager.GetProductById(id);         
        return theProduct;
    }
}
