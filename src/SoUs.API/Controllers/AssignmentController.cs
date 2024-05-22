using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SoUs.DataAccess;

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

        [HttpGet(nameof(GetTasks))]
        public ActionResult GetTasks()
        {
            var tasks = _repository.GetAll();
            return Ok(tasks);
        }

        [HttpGet(nameof(GetTask))]
        public ActionResult GetTask(int id)
        {
            var task = _repository.GetById(id);
            return Ok(task);
        }

        [HttpGet(nameof(GetTasksOnDate))]
        public ActionResult GetTasksOnDate(string date)
        {
            var tasks = _repository.GetAssignmentsOn(System.DateTime.Parse(date));
            return Ok(tasks);
        }

        [HttpGet(nameof(GetTasksForEmployee))]
        public ActionResult GetTasksForEmployee(string name)
        {
            var tasks = _repository.GetAssignmentsForEmployee(name);
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult CreateTask(Entities.Assignment task)
        {
            _repository.Add(task);
            return Ok();
        }


    }
}
