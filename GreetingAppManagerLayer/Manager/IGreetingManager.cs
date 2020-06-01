using GreetingAppCommannLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GreetingAppManagerLayer.Manager
{
    public interface IGreetingManager
    {
        IEnumerable<GreetingModel> GetAllGreetingModels();
        GreetingModel GetGreetingModel(int EmployeeId);
        Task<int> Add(GreetingModel employee);
        void Update(GreetingModel employeeChanges);
        GreetingModel Delete(int Employee);
        bool Login(string username, string password);
        void save();
       
    }
}
