using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoUs.Entities;
using SoUs.DataAccess;

namespace SoUs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubTaskController : ControllerBase
    {
        private readonly IRepository<SubTask> _repository;

        public SubTaskController(IRepository<SubTask> repository)
        {
            _repository = repository;
        }

        [HttpGet(nameof(GetSubTasks))]
        public ActionResult GetSubTasks()
        {
            try
            {
                var subTasks = _repository.GetAll();
                return Ok(subTasks);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet(nameof(GetSubTaskById))]
        public ActionResult GetSubTaskById(int id)
        {
            try
            {
                var subTask = _repository.GetById(id);
                return Ok(subTask);
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost(nameof(AddSubTask))]
        public ActionResult AddSubTask([FromBody] SubTask subTask)
        {
            try
            {
                _repository.Add(subTask);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut(nameof(UpdateSubTask))]
        public ActionResult UpdateSubTask([FromBody] SubTask subTask)
        {
            try
            {
                _repository.Update(subTask);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete(nameof(DeleteSubTask))]
        public ActionResult DeleteSubTask(int id)
        {
            try
            {
                _repository.Delete(id);
                return Ok();
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
