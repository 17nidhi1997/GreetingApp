using GreetingAppCommannLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreetingAppRepositoriesLayer
{
    public interface IGreetingRepository
    {
        GreetingModel GetGreetingModel(int EmployeeId);
        IEnumerable<GreetingModel> GetAllGreetingModels();
        GreetingModel Add(GreetingModel employee);
        GreetingModel Update(GreetingModel employeeChanges);
        GreetingModel Delete(int EmployeeId);
    }
}
