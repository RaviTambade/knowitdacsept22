namespace DAL;
using BOL;
using System.Data;
using MySql.Data.MySqlClient; //managed DB providers
//interfaces used for database connectivity
//IDbConnection,IDbCommand ,IDbDataApater ,IDbDataReader
//IDbTrancation

//classes 
//DataSet,DataTable,DataRow,DataColumn

//Two ways of database connectivity using .net
//Dotnet dependency Manager tool Nugget Package Manager
//dotnet command :
//dotnet add package mysql.data

public static class MySqlRepository{

     public static string conString=@"server=localhost;port=3306;user=root; password=password;database=ecommerce"; 
    public static List<Product> GetAll(){
        List<Product> products=new List<Product>();
        //database connectivity Code
        string query="SELECT * FROM products";
        //Connected data Access
        IDbConnection con=new MySqlConnection();
        con.ConnectionString=conString;
        IDbCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText=query;
        try{
            con.Open();
            IDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                string id=reader["productCode"].ToString();
                string title=reader["productName"].ToString();
                string description=reader["productDescription"].ToString();
                int stockAvailable=int.Parse(reader["quantityInStock"].ToString());
                double unitPrice=double.Parse(reader["buyPrice"].ToString());
                string category=reader["productLine"].ToString();
                Product product=new Product{
                    ProductId=id,
                    Title=title,
                    Description=description,
                    UnitPrice=unitPrice,
                    Category=category,
                    StockAvailable=stockAvailable,
                    ImageUrl="/images/nano.jpg"
                };
                products.Add(product);
            }

        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
        return products;
    }
}