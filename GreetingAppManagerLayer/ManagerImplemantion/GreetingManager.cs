using GreetingAppCommannLayer;
using GreetingAppManagerLayer.Manager;
using GreetingAppRepositoriesLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingAppManagerLayer.ManagerImplemantion
{
    public class GreetingManager: IGreetingManager
    {
        private RepoDbContext _context;
        public GreetingManager(RepoDbContext context)
        {
            _context = context;
        }
        public Task<int> Add(GreetingModel employee)
        {
            _context.Employees.Add(employee);
            return _context.SaveChangesAsync();
        }
        public GreetingModel Delete(int Employeeid)
        {
            GreetingModel model = _context.Employees.Find(Employeeid);
            if (model != null)
                _context.Employees.Remove(model);
            _context.SaveChanges();
            return model;
        }
        public IEnumerable<GreetingModel> GetAllGreetingModels()
        {
            return _context.Employees.ToList();
        }
        public GreetingModel GetGreetingModel(int EmployeeId)
        {
            return _context.Employees.Where(x => x.EmployeeId == EmployeeId).FirstOrDefault();
        }
        public bool Login(string username, string password)
        {
            var result = _context.Employees.Where(id => id.EmailId == username && id.Password == password);
            if (result != null)
            {
                return true;
            }
            return false;
        }

     
        public void save()
        {
            _context.SaveChanges();
        }


        public void Update(GreetingModel employeeChanges)
        {
            _context.Employees.Update(employeeChanges);
        }
    }
}
