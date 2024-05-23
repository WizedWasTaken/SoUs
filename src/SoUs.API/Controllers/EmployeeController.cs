using Microsoft.AspNetCore.Mvc;
using SoUs.DataAccess;
using SoUs.Entities;

namespace SoUs.API.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet(nameof(GetEmployees))]
        public ActionResult GetEmployees()
        {
            try
            {
                var employees = _repository.GetAll();
                return Ok(employees);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public ActionResult GetEmployeeByCareCenter(CareCenter careCenter)
        {
            try
            {
                var employees = _repository.GetEmployeesByCareCenter(careCenter);
                return Ok(employees);
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet(nameof(GetEmployeeById))]
        public ActionResult GetEmployeeById(int id)
        {
            try
            {
                var employee = _repository.GetById(id);
                return Ok(employee);
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet(nameof(GetEmployeeByRole))]
        public ActionResult GetEmployeeByRole(Role role)
        {
            try
            {
                var employees = _repository.GetEmployeesByRole(role);
                return Ok(employees);
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost(nameof(AddEmployee))]
        public ActionResult AddEmployee([FromBody] Employee employee)
        {
            try
            {
                _repository.Add(employee);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut(nameof(UpdateEmployee))]
        public ActionResult UpdateEmployee([FromBody] Employee employee)
        {
            try
            {
                _repository.Update(employee);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete(nameof(DeleteEmployee))]
        public ActionResult DeleteEmployee(int id)
        {
            try
            {
                _repository.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
