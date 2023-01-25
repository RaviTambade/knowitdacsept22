using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;

using System.Collections.Generic;
using HRWebApi.Models;
using HRWebApi.DAL;

namespace HRWebApi.Controllers;

//http:\\localhost:5080\hr
[ApiController]
[Route("[controller]")]
public class HRController : ControllerBase
{ 
    private readonly ILogger<HRController> _logger;

    public HRController(ILogger<HRController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAllEmployees")]
    public IEnumerable<Employee> Get()
    {
        List<Employee> employees=HRDBManager.GetAll();
        return employees.ToArray();
    }

    
    [HttpGet]
    [Route("{id}")]
    public ActionResult<Employee>  GetById(int id){
       Employee emp=  HRDBManager.GetById(id);
       return emp;
    }

    [HttpDelete]
    [Route("{id}")]
    public ActionResult<Employee>  DeleteById(int id){
       Employee emp=  HRDBManager.GetById(id);
       bool status=HRDBManager.DeleteById(id);
       if(status){
            return NoContent();
       }   
       else{
        return NotFound();

       }
       return emp;
    }

    [HttpPut("{id}")]
    public  ActionResult Update(int id, Employee emp)
    {
        bool status=HRDBManager.Update(id, emp);
       if(status){
            return NoContent();
       }   
       else{
        return NotFound();
       }
    }


    [HttpPost]
    public  ActionResult Insert( Employee emp)
    {
        bool status=HRDBManager.Insert(emp);
       if(status){
            return NoContent();
       }   
       else{
        return NotFound();
       }
    }
}