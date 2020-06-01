using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetingAppCommannLayer;
using GreetingAppManagerLayer.Manager;
using GreetingAppManagerLayer.ManagerImplemantion;
using GreetingAppRepositoriesLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace GreetingApp.Controlleres
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IGreetingManager _greetingManager;
        public EmployeeController(GreetingManager greetingmanager)
        {
            _greetingManager = greetingmanager;
        }
        [Route("Add")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(GreetingModel employee)
        {
            var result = await this._greetingManager.Add(employee);
            if(result==1)
            {
                return this.Ok(employee);
            }
            else
            {
                Log.Error("This is bad nw");
                return this.BadRequest();
            }            
        }
      
        [HttpGet]
        public IEnumerable<GreetingModel> GetAllGreetingModels()
        {
            Log.Information("list is added");
            return this._greetingManager.GetAllGreetingModels();
        }
        
        [Route("{id}")]
        [HttpGet]
        public GreetingModel GetGreetingModel(int EmployeeId)
        {
            Log.Information("Employee details ");
            return this._greetingManager.GetGreetingModel(EmployeeId);
        }
        
        [Route("Update")]
        [HttpGet]
        public void UpdateEmployee(GreetingModel employeeChanges)
        {
            this._greetingManager.Update(employeeChanges);
        }

        [Route("{id}")]
        [HttpPost]
        public GreetingModel DeleteEmployee(int id)
        {
            Log.Information("employee with id was deleted");
            return this._greetingManager.Delete(id);
        }

        [Route("Login")]
        [HttpPost]
        public IActionResult Login(GreetingModel model)
        {
            var result = _greetingManager.Login(model.EmailId, model.Password);
            if (result == true)
            {
                return this.Ok(model.EmailId);
            }
            else
                return this.BadRequest();
        }

    }
}