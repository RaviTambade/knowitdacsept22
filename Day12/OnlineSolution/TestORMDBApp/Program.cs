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


Console.WriteLine("Get By Id");

Employee emp1=ORMDBManager.GetById(1);
Console.WriteLine(emp1.FirstName + " "+ emp1.LastName + " "+ emp1.Email);
   
Employee emp3=new Employee{
    Id=99,
    FirstName="Chirag",
    LastName= "Jadhav",
    Email="Chirag Jadhav@gmail.com",
    Address="Chennai",
    DeptId=2,
    ManagerId=1,
    Password="seed"
    
};

bool status=ORMDBManager.Insert(emp3);
if(status){
    Console.WriteLine("Inserted successfully");

}


List<Employee> employees2=ORMDBManager.GetAll();
foreach( Employee emp in employees2)
{
    Console.WriteLine(emp.FirstName + " "+ emp.LastName + " "+ emp.Email);
    
}
