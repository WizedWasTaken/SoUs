using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SoUs.DataAccess;
using SoUs.Entities;

namespace SoUs.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssignmentController : Controller
    {
        private readonly IAssignmentRepository _repository;

        public AssignmentController(IAssignmentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet(nameof(GetAssignments))]
        public ActionResult GetAssignments()
        {
            try
            {
                var tasks = _repository.GetAll();
                return Ok(tasks);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet(nameof(GetAssignmentsById))]
        public ActionResult GetAssignmentsById(int id)
        {
            try
            {
                var task = _repository.GetById(id);
                return Ok(task);
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet(nameof(GetAssignmentsOnDate))]
        public ActionResult GetAssignmentsOnDate(string date)
        {
            try
            {
                var tasks = _repository.GetAssignmentsOn(System.DateTime.Parse(date));
                return Ok(tasks);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet(nameof(GetAssignmentsForEmployee))]
        public ActionResult GetAssignmentsForEmployee(Employee employee)
        {
            try
            {
                var tasks = _repository.GetAssignmentsForEmployee(employee);
                return Ok(tasks);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateAssignment(Assignment task)
        {
            try
            {
                _repository.Add(task);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
