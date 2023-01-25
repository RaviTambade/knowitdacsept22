using BOL;
using DAL;

//Dotnet CLI command to downlaod MySQL ORM package
//dotnet add package MySql.EntityFrameworkCore

Console.WriteLine("Hello World ORM");


List<Employee> employees=ORMDBManager.GetAll();
foreach( Employee emp in employees)
{
    Console.WriteLine(emp.FirstName + " "+ emp.LastName + " "+ emp.Email);
    
}