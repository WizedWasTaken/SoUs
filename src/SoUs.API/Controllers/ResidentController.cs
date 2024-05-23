using Microsoft.AspNetCore.Mvc;
using SoUs.DataAccess;
using SoUs.Entities;

namespace SoUs.API.Controllers
{
    public class ResidentController : Controller
    {
        private readonly IRepository<Resident> _repository;

        public ResidentController(IRepository<Resident> repository)
        {
            _repository = repository;
        }

        [HttpGet(nameof(GetResidents))]
        public ActionResult GetResidents()
        {
            try
            {
                var residents = _repository.GetAll();
                return Ok(residents);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet(nameof(GetResidentById))]
        public ActionResult GetResidentById(int id)
        {
            try
            {
                var resident = _repository.GetById(id);
                return Ok(resident);
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost(nameof(AddResident))]
        public ActionResult AddResident([FromBody] Resident resident)
        {
            try
            {
                _repository.Add(resident);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut(nameof(UpdateResident))]
        public ActionResult UpdateResident([FromBody] Resident resident)
        {
            try
            {
                _repository.Update(resident);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete(nameof(DeleteResident))]
        public ActionResult DeleteResident(int id)
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
