namespace BOL;
public class Order{
    public DateTime OrderDate{get;set;}
    public double TotalAmount{get;set;}
    public string Status{get;set;}

    public List<Item> Items{get;set;}
}



//Clean code Strategy
