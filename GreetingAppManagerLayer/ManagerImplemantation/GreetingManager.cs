using GreetingAppCommannLayer;
using GreetingAppRepositoriesLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GreetingAppManagerLayer.ManagerImplemantation
{
    public class GreetingManager : IGreetingManager
    {
        private IGreetingRepository _repository;
        public GreetingManager(IGreetingRepository repository)
        {
            _repository = repository;
        }
        public Task<int> AddEmployee(GreetingModel employee)
        {
            return this._repository.AddEmployee(employee);
        }
        public GreetingModel DeleteEmployee(int Employee)
        {
            return this._repository.DeleteEmployee(Employee);
        }
        public IEnumerable<GreetingModel> GetAllGreetingModels()
        {
            return this._repository.GetAllGreetingModels();
        }
        public GreetingModel GetGreetingModel(int EmployeeId)
        {
            return this._repository.GetGreetingModel(EmployeeId);
        }       
        public void saveEmployee()
        {
            throw new NotImplementedException();
        }
        public Task<int> UpdateEmployee(GreetingModel employeeChanges)
        {
            return this._repository.UpdateEmployee(employeeChanges);
        }
    }
}
