using BOL;
namespace DAL;
public  static class ORMDBManager{

public static List<Employee> GetAll(){
    //Disposing
    using(var context=new CollectionContext())
    {
        //LINQ
        var employees=from emp in context.Employees select emp;
        return employees.ToList<Employee>();
    }
}


public static  Employee  GetById(int id){
    Employee foundEmployee =null;
    //Disposing
    using(var context=new CollectionContext())
    {
        var emp = context.Employees.FirstOrDefault(s => s.Id ==id);
        context.SaveChangesAsync();
        foundEmployee=emp;    
    }
    return foundEmployee;
}

public static bool Insert(Employee emp){
    bool status=false;
    using(var context=new CollectionContext())
    {
            context.Add(emp);
            context.SaveChangesAsync();
            status=true;
    }
    return status;
}

public static bool Update(Employee emp){
    bool status=false;
    using(var context=new CollectionContext())
    {  
      var studentToUpdate = context.Employees.FirstOrDefault(s => s.Id ==emp.Id);
  
         context.Add(emp);
            context.SaveChangesAsync();
            status=true;
    }
    return status;
}
public static bool Remove(int id){
  bool status=false;
  using(var context=new CollectionContext())
  {
    var studentToDelete = context.Employees.Find(id);
    context.Employees.Remove(studentToDelete);
    context.SaveChangesAsync();
    status=true;
    }
    return status;
}

}