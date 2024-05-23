using Microsoft.AspNetCore.Mvc;
using SoUs.DataAccess;
using SoUs.Entities;

namespace SoUs.API.Controllers
{
    public class AddressController : Controller
    {
        private readonly IRepository<Address> _repository;

        public AddressController(IRepository<Address> repository)
        {
            _repository = repository;
        }

        [HttpGet(nameof(GetAddresses))]
        public ActionResult GetAddresses()
        {
            try
            {
                var addresses = _repository.GetAll();
                return Ok(addresses);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet(nameof(GetAddressById))]
        public ActionResult GetAddressById(int id)
        {
            try
            {
                var address = _repository.GetById(id);
                return Ok(address);
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost(nameof(AddAddress))]
        public ActionResult AddAddress([FromBody] Address address)
        {
            try
            {
                _repository.Add(address);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut(nameof(UpdateAddress))]
        public ActionResult UpdateAddress([FromBody] Address address)
        {
            try
            {
                _repository.Update(address);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete(nameof(DeleteAddress))]
        public ActionResult DeleteAddress(int id)
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
