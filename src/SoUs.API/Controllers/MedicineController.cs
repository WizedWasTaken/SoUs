using Microsoft.AspNetCore.Mvc;
using SoUs.DataAccess;
using SoUs.Entities;

namespace SoUs.API.Controllers
{
    public class MedicineController : Controller
    {
        private readonly IRepository<Medicine> _repository;

        public MedicineController(IRepository<Medicine> repository)
        {
            _repository = repository;
        }

        [HttpGet(nameof(GetMedicines))]
        public ActionResult GetMedicines()
        {
            try
            {
                var medicines = _repository.GetAll();
                return Ok(medicines);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet(nameof(GetMedicineById))]
        public ActionResult GetMedicineById(int id)
        {
            try
            {
                var medicine = _repository.GetById(id);
                return Ok(medicine);
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost(nameof(AddMedicine))]
        public ActionResult AddMedicine([FromBody] Medicine medicine)
        {
            try
            {
                _repository.Add(medicine);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut(nameof(UpdateMedicine))]
        public ActionResult UpdateMedicine([FromBody] Medicine medicine)
        {
            try
            {
                _repository.Update(medicine);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete(nameof(DeleteMedicine))]
        public ActionResult DeleteMedicine(int id)
        {
            try
            {
                _repository.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
