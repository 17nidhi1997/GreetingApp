using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GreetingAppCommannLayer;
using GreetingAppManagerLayer;
using GreetingAppRepositoriesLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace GreetingApp.Controlleres
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IGreetingManager _Manager;
        
        public EmployeeController(IGreetingManager manager)
        {
            _Manager = manager;
        }
        [Route("AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(GreetingModel employee) 
        {
               var result = await this._Manager.AddEmployee(employee);
               if(result==1)
               {
                   return this.Ok(employee);
               }
               else
               {
                   Log.Error("This is bad network");
                   return this.BadRequest();
               }        
        }  
        
        [HttpGet]
        public IEnumerable<GreetingModel> GetAllGreetingModels()
        {
            Log.Information("list is added");
            return this._Manager.GetAllGreetingModels();
        }     
        [Route("EmployeeId")]
        [HttpGet]
        public GreetingModel GetGreetingModel(int EmployeeId)
        {
            Log.Information("Employee details ");
            return this._Manager.GetGreetingModel(EmployeeId);
        }     
        [Route("Update")]
        [HttpPut]
        public void UpdateEmployee(GreetingModel employeeChanges)
        {
            this._Manager.UpdateEmployee(employeeChanges);
        }
        [HttpDelete]
        [Route("{EmployeeId}")]
        public GreetingModel DeleteEmployee(int EmployeeId)
        {
            Log.Information("employee with id was deleted");
            return this._Manager.DeleteEmployee(EmployeeId);
        }
    }
}