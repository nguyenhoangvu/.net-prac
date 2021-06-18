using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDApp.Model;
using CRUDApp.Service;

namespace CRUDApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // get list
        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployees")]
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeService.GetEmployees();
        }
        // add employee
        [HttpPost]
        [Route("[action]")]
        [Route("api/Employee/AddEmployee")]
        public IActionResult AddEmployee(Employee e)
        {
            _employeeService.AddEmployee(e);
            return Ok();
        }
        // update employee
        [HttpPost]
        [Route("[action]")]
        [Route("api/Employee/UpdateEmployee")]
        public IActionResult UpdateEmployee(Employee e)
        {
            _employeeService.UpdateEmployee(e);
            return Ok();
        }
        // update employee
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Employee/DeleteEmployee")]
        public IActionResult DeleteEmployee(int id)
        {
            var existingEm = _employeeService.GetEmployee(id);
            if (existingEm != null)
            {
                _employeeService.DeleteEmployee(existingEm.Id);
                return Ok();
            }
            return NotFound($"Employee Not Found with ID : {existingEm.Id}");
        }
        // update employee
        [HttpGet]
        [Route("GetEmployee")]
        public Employee GetEmployee(int id)
        {
            return _employeeService.GetEmployee(id);
        }
    }
}
