// See https://aka.ms/new-console-template for more information
using dependency_Injection_constructor;

var employeeBL = new EmployeeBL(new EmployeeDAL());
var ListEmployee = employeeBL.GetAllEmployees();
foreach (Employee emp in ListEmployee)
{
    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
}
Console.ReadKey();
        