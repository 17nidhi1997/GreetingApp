using GreetingAppCommannLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreetingAppRepositoriesLayer
{
    public class GreetingRepository:IGreetingRepository
    {
        private List<GreetingModel> _greetingModelsList;
        public GreetingRepository()
        {
           /* _greetingModelsList = new List<GreetingModel>()
            {
              new GreetingModel(){ EmployeeId=1,FirstName="nidhi",LastName="R",EmailId="nidhiNavya1997@gmail.com",Password="@123",MobileNumber="9972438479",Salary="10000"},
               new GreetingModel(){ EmployeeId=2,FirstName="nidhi",LastName="R",EmailId="nidhiNavya1997@gmail.com",Password="@123",MobileNumber="9972438479",Salary="10000"},
               new GreetingModel(){ EmployeeId=3,FirstName="nidhi",LastName="R",EmailId="nidhiNavya1997@gmail.com",Password="@123",MobileNumber="9972438479",Salary="10000"}
            };*/
            throw new NotImplementedException();
        }
        public GreetingModel GetGreetingModel(int EmployeeId)
        {
            throw new NotImplementedException();
        }      
        public IEnumerable<GreetingModel> GetAllGreetingModels()
        {
            throw new NotImplementedException();
        }
        public GreetingModel Add(GreetingModel employee)
        {
            throw new NotImplementedException();
        }
        public GreetingModel Update(GreetingModel employeeChanges)
        {
            throw new NotImplementedException();
        }
        public GreetingModel Delete(int EmployeeId)
        {
            throw new NotImplementedException();
        }
    }
}
