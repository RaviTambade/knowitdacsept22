namespace DAL;
using BOL;
using System.Text.Json;
using System.IO;


public  static class ProductsRepository
{
    public static  List<Product> GetAll()
    {
            List<Product> allProducts=new List<Product>();
            string restoredJsonString=File.ReadAllText(@"D:\Ravi\test\products.json");
            List<Product> restoredProducts=JsonSerializer.Deserialize<List<Product>>(restoredJsonString);
            return restoredProducts;
    }

    public static Product GetById(int id){

          List<Product> products=GetAll();
          var  theProduct= (from prod in products
                          where prod.ProductId == id
                          select prod);

          //return (Product)theProduct;
          return theProduct.First<Product>();

    }

    public  static bool  Insert(Product product){
         bool status=false;
         List<Product> products=GetAll();
         products.Add(product);
         string jsonString=JsonSerializer.Serialize(products);
          File.WriteAllText(@"D:\Ravi\test\products.json",jsonString);

         status=true;
         return status;
    }


    public  static bool Delete(int id){
         bool status=false;
         List<Product> products=GetAll();
         Product theProduct=GetById(id);
         products.Remove(theProduct);
         string jsonString=JsonSerializer.Serialize(products);
          File.WriteAllText(@"D:\Ravi\test\products.json",jsonString);

         status=true;
         return status;
    }


    public static bool Update(Product product){
         bool status=false;
         List<Product> products=GetAll();
        //Logic to Update existing Product from products collection
          string jsonString=JsonSerializer.Serialize(products);
          File.WriteAllText(@"D:\Ravi\test\products.json",jsonString);


         status=true;
         return status;
    }

}
