using Microsoft.AspNetCore.Mvc;
using SoUs.DataAccess;
using SoUs.Entities;

namespace SoUs.API.Controllers
{
    public class DiagnosisController : Controller
    {
        private readonly IRepository<Diagnosis> _repository;

        public DiagnosisController(IRepository<Diagnosis> repository)
        {
            _repository = repository;
        }

        [HttpGet(nameof(GetDiagnoses))]
        public ActionResult GetDiagnoses()
        {
            try
            {
                var diagnoses = _repository.GetAll();
                return Ok(diagnoses);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet(nameof(GetDiagnosisById))]
        public ActionResult GetDiagnosisById(int id)
        {
            try
            {
                var diagnosis = _repository.GetById(id);
                return Ok(diagnosis);
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost(nameof(AddDiagnosis))]
        public ActionResult AddDiagnosis([FromBody] Diagnosis diagnosis)
        {
            try
            {
                _repository.Add(diagnosis);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut(nameof(UpdateDiagnosis))]
        public ActionResult UpdateDiagnosis([FromBody] Diagnosis diagnosis)
        {
            try
            {
                _repository.Update(diagnosis);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete(nameof(DeleteDiagnosis))]
        public ActionResult DeleteDiagnosis(int id)
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
