using Microsoft.AspNetCore.Mvc;
using SoUs.DataAccess;
using SoUs.Entities;

namespace SoUs.API.Controllers
{
    public class PrescriptionController : Controller
    {
        private readonly IRepository<Prescription> _repository;

        public PrescriptionController(IRepository<Prescription> repository)
        {
            _repository = repository;
        }

        [HttpGet(nameof(GetPrescriptions))]
        public ActionResult GetPrescriptions()
        {
            try
            {
                var prescriptions = _repository.GetAll();
                return Ok(prescriptions);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet(nameof(GetPrescriptionById))]
        public ActionResult GetPrescriptionById(int id)
        {
            try
            {
                var prescription = _repository.GetById(id);
                return Ok(prescription);
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost(nameof(AddPrescription))]
        public ActionResult AddPrescription([FromBody] Prescription prescription)
        {
            try
            {
                _repository.Add(prescription);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut(nameof(UpdatePrescription))]
        public ActionResult UpdatePrescription([FromBody] Prescription prescription)
        {
            try
            {
                _repository.Update(prescription);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete(nameof(DeletePrescription))]
        public ActionResult DeletePrescription(int id)
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
