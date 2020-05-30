using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetingAppRepositoriesLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace GreetingApp.Controlleres
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IGreetingRepository _greetingRepository;
        public EmployeeController(IGreetingRepository greetingRepository)
        {
            _greetingRepository = greetingRepository;
        }
        public ActionResult Create()
        {
            // var Employee = _greetingRepository.GetAllGreetingModels();
            return View();
        }

    }
}