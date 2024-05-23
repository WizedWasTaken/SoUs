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
            var tasks = _repository.GetAll();
            return Ok(tasks);
        }

        [HttpGet(nameof(GetAssignmentsById))]
        public ActionResult GetAssignmentsById(int id)
        {
            var task = _repository.GetById(id);
            return Ok(task);
        }

        [HttpGet(nameof(GetAssignmentsOnDate))]
        public ActionResult GetAssignmentsOnDate(string date)
        {
            var tasks = _repository.GetAssignmentsOn(System.DateTime.Parse(date));
            return Ok(tasks);
        }

        [HttpGet(nameof(GetAssignmentsForEmployee))]
        public ActionResult GetAssignmentsForEmployee(Employee employee)
        {
            var tasks = _repository.GetAssignmentsForEmployee(employee);
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult CreateAssignment(Assignment task)
        {
            _repository.Add(task);
            return Ok();
        }


    }
}
