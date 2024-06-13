using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoUs.DataAccess;
using SoUs.Entities;

namespace SoUs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineTaskController : ControllerBase
    {
        private readonly IRepository<MedicineTask> _repository;

        public MedicineTaskController(IRepository<MedicineTask> repository)
        {
            _repository = repository;
        }

        [HttpGet(nameof(GetMedTasks))]
        public ActionResult GetMedTasks()
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

        [HttpGet(nameof(GetMedTaskById))]
        public ActionResult GetMedTaskById(int id)
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

        [HttpPost(nameof(AddMedTask))]
        public ActionResult AddMedTask([FromBody] MedicineTask medTask)
        {
            try
            {
                _repository.Add(medTask);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut(nameof(UpdateMedTask))]
        public ActionResult UpdateMedTask([FromBody] MedicineTask medTask)
        {
            try
            {
                _repository.Update(medTask);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete(nameof(DeleteMedTas))]
        public ActionResult DeleteMedTas(int id)
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
