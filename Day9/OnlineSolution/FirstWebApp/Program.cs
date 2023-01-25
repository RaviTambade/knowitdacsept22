using BOL;
using System.Net.Mime;

//Minimal Code Strategy
var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<RouteOptions> (o =>{
    o.LowercaseUrls =true;
    o.AppendTrailingSlash = true;
    o.LowercaseQueryStrings =false;

});
var app = builder.Build();

app.MapGet("/", () => "Hello Knowit!");
app.MapGet("/transflower", () => "Welcome to <b> Transflower</b>");
app.MapGet("/aboutus",() =>"<u>Mentor as a Service</u>");
app.MapGet("/contact",()=>"ravi.tambade@transflower.in");
string [] services={"corporate trainigns","online workshops", "cdac trainings",
                     "dev camps", "Tech ed events"};
app.MapGet("/services",()=>services);

app.MapGet("/teapot", (HttpResponse response) =>
{
    response.StatusCode = 418;
    response.ContentType = MediaTypeNames.Text.Plain;
    return response.WriteAsync("I'm a teapot!");
});


var people= new List<Person> 
{
    new Person {Id=1, FirstName="Tom", LastName="Hanks"},
    new Person {Id=2, FirstName="Denzel", LastName="Washington"},
    new Person {Id=3, FirstName="Leondardo", LastName="DiCaprio"},
    new Person {Id=4, FirstName="Al", LastName="Pacino"},
    new Person{Id=5, FirstName="Morgan", LastName="Freeman"},
};
app.MapGet("/person/{name}",(string name)=>people.Where(p=>p.FirstName.StartsWith(name)));

app.MapGet("/api/customers/{id}", (int id) => "customer id ="+ id);
 
app.MapGet("/fruit", () => Fruit.All);
 
var getFruit = (string id) => Fruit.All[id];
app.MapGet("/fruit/{id}", getFruit);
 
app.MapPost("/fruit/{id}", Handlers.AddFruit);
 
Handlers handlers = new();
app.MapPut("/fruit/{id}", handlers.ReplaceFruit);
 
app.MapDelete("/fruit/{id}", DeleteFruit);
 

 



//app.MapGet("/products/{category}/{name}",()=>"product details"); ///trousers/mens/formal
//  /products/bags/rucksack-a           category=bags    name=rucksack-a
//  /shoes/black-size9                  category=shoes   name=black-size9


app.MapGet("/products/{category}/{name=all}/{id?}",()=>"product details"); ///trousers/mens/formal
/*

/product/shoes/formal/3                 category=shoes, name=formal, id=3

/product/shoes/formal                   category=shoes, name=formal

/product/shoes                          category=shoes, name=all

/product/bags/satchels                  category=bags, name=satchels

/product/phones                         category=phones, name=all

/product/computers/laptops/ABC-123      category=computers, name=laptops, id=ABC-123

*/



/*
A few route constraints and their behavior when applied

Constraint              Example             Match examples                          Description

int                     {qty:int}           123, -123, 0                            Matches any integer
Guid                    {id:guid}           d071b70c-a812-4b54-87d2-7769528e2814    Matches any Guid
decimal                 {cost:decimal}      29.99, 52, -1.01                        Matches any decimal value
min(value)              {age:min(18)}       18, 20                                  Matches integer values of 18 or greater
length(value)           {name:length(6)}    andrew,123456                           Matches string values with a length of 6
optional int            {qty:int?}          123, -123, 0, null                      Optionally matches any integer
optional int max(value) {qty:int:max(10)?}  3, -123, 0, null                        Optionally matches any integer of 10 or less




*/

//Generating  a URL LinkGenerator and named endpoint


//app.MapGet("/products/{name}", (string name) => $"The product is {name}").WithName("product");
 
app.MapGet("/links", (LinkGenerator links) =>{
                    string link = links.GetPathByName("product",new { name = "big-widget"});
                    return $"View the product at {link}";
});

app.MapGet("/test", () =>"Hello World").WithName("hello");
app.MapGet("/redirect-me", () =>Results.RedirectToRoute("hello"));

//Generating a redirect URL using Results.RedirectToRoute()



app.MapGet("/HealthCheck", () => Results.Ok()).WithName("healthcheck");
app.MapGet("/{name}", (string name) => name).WithName("product");
 
app.MapGet("/", (LinkGenerator links) => 
new [] 
{
    links.GetPathByName("healthcheck"),
    links.GetPathByName("product",
        new { Name = "Big-Widget", Q = "Test"})
});



/*
Method                              HTTP verb          Expected operation

MapGet(path, handler)               GET                 Fetch data only, no modification of state. May be safe to cache.
MapPost(path, handler)              POST                Create a new resource
MapPut(path, handler)               PUT                 Create or replace an existing resource
MapDelete(path, handler)            DELETE              Delete the given resource
MapPatch(path, handler)             PATCH               Modify the given resource
MapMethods(path, methods, handler)  Multiple verbs      Not applicable
Map(path, handler)                  All verbs           Not applicable
MapFallback(handler)                All verbs           Useful for SPA fallback routes
*/
app.Run();

//app.MapPost("/register",()=>"data is posted....");

void DeleteFruit(string id)
{
    Fruit.All.Remove(id);
}

record Fruit(string Name, int Stock)
{
    public static readonly Dictionary<string, Fruit> All = new();
};
 