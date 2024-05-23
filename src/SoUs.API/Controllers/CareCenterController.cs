using Microsoft.AspNetCore.Mvc;
using SoUs.DataAccess;
using SoUs.Entities;

namespace SoUs.API.Controllers
{
    public class CareCenterController : Controller
    {
        private readonly IRepository<CareCenter> _repository;

        public CareCenterController(IRepository<CareCenter> repository)
        {
            _repository = repository;
        }

        [HttpGet(nameof(GetCareCenters))]
        public ActionResult GetCareCenters()
        {
            try
            {
                var careCenters = _repository.GetAll();
                return Ok(careCenters);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet(nameof(GetCareCenterById))]
        public ActionResult GetCareCenterById(int id)
        {
            try
            {
                var careCenter = _repository.GetById(id);
                return Ok(careCenter);
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost(nameof(AddCareCenter))]
        public ActionResult AddCareCenter([FromBody] CareCenter careCenter)
        {
            try
            {
                _repository.Add(careCenter);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut(nameof(UpdateCareCenter))]
        public ActionResult UpdateCareCenter([FromBody] CareCenter careCenter)
        {
            try
            {
                _repository.Update(careCenter);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete(nameof(DeleteCareCenter))]
        public ActionResult DeleteCareCenter(int id)
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
