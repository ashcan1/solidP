using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependency_Injection_constructor
{
    public class EmployeeDAL : IEmployeeDAL
        {
     
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>();
            //Get the Employees from the Database
            //for now we are hard coded the employees
            ListEmployees.Add(new Employee() { ID = 1, Name = "Ash", Department = "IT" });
            ListEmployees.Add(new Employee() { ID = 2, Name = "Sam", Department = "HR" });
            ListEmployees.Add(new Employee() { ID = 3, Name = "Jordan", Department = "Payroll" });

            return ListEmployees;
        }
    }
}
