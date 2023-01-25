
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
}