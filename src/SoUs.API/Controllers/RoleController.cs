using Microsoft.AspNetCore.Mvc;
using SoUs.DataAccess;
using SoUs.Entities;

namespace SoUs.API.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRepository<Role> _repository;

        public RoleController(IRepository<Role> repository)
        {
            _repository = repository;
        }

        [HttpGet(nameof(GetRoles))]
        public ActionResult GetRoles()
        {
            try
            {
                var roles = _repository.GetAll();
                return Ok(roles);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet(nameof(GetRoleById))]
        public ActionResult GetRoleById(int id)
        {
            try
            {
                var role = _repository.GetById(id);
                return Ok(role);
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost(nameof(AddRole))]
        public ActionResult AddRole([FromBody] Role role)
        {
            try
            {
                _repository.Add(role);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut(nameof(UpdateRole))]
        public ActionResult UpdateRole([FromBody] Role role)
        {
            try
            {
                _repository.Update(role);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete(nameof(DeleteRole))]
        public ActionResult DeleteRole(int id)
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
