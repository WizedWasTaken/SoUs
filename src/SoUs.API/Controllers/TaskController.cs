using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SoUs.DataAccess;

namespace SoUs.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : Controller
    {
        private readonly IRepository<Entities.Task> _repository;

        public TaskController(IRepository<Entities.Task> repository)
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

        [HttpPost]
        public IActionResult CreateTask(Entities.Task task)
        {
            _repository.Add(task);
            return Ok();
        }


    }
}
