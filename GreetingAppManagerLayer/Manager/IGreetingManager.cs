using GreetingAppCommannLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GreetingAppManagerLayer
{
    public interface IGreetingManager
    {
        IEnumerable<GreetingModel> GetAllGreetingModels();
        GreetingModel GetGreetingModel(int EmployeeId);
        Task<int> AddEmployee(GreetingModel employee);
        Task<int> UpdateEmployee(GreetingModel employeeChanges);
        GreetingModel DeleteEmployee(int Employee);
        void saveEmployee();
    }
}
