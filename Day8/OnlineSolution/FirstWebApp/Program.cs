using BOL;


//Minimal Code Strategy


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Knowit!");
app.MapGet("/transflower", () => "Welcome to <b> Transflower</b>");
app.MapGet("/aboutus",() =>"<u>Mentor as a Service</u>");
app.MapGet("/contact",()=>"ravi.tambade@transflower.in");
string [] services={"corporate trainigns","online workshops", "cdac trainings",
                     "dev camps", "Tech ed events"};
app.MapGet("/services",()=>services);

Person p1=new Person() { Id=34, FirstName="Sameer", LastName="Jadhav"};
app.MapGet("/api/person/34",()=>p1);


app.Run();

//app.MapPost("/register",()=>"data is posted....");
