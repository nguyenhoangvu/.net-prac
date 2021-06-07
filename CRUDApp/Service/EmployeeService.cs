using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDApp.Model;
using CRUDApp.Context;
namespace CRUDApp.Service
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeContext _employeeDbContext;
        public EmployeeService(EmployeeContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }
        public Employee AddEmployee(Employee e)
        {
            _employeeDbContext.Employees.Add(e);
            _employeeDbContext.SaveChanges();
            return e;
        }
        public List<Employee> GetEmployees()
        {
            return _employeeDbContext.Employees.ToList();
        }
        public void UpdateEmployee(Employee e)
        {
            _employeeDbContext.Employees.Update(e);
            _employeeDbContext.SaveChanges();
        }
        public void DeleteEmployee(int Id)
        {
            var e = _employeeDbContext.Employees.FirstOrDefault(x => x.Id == Id);
            if (e != null)
            {
                _employeeDbContext.Remove(e);
                _employeeDbContext.SaveChanges();
            }
        }
        //public Employee Get
    }
}
