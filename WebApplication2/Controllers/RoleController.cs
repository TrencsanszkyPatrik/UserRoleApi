using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Models.DtoS;
using WebApplication2.Services.IServices;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRole _role;
        public RoleController(IRole role)
        {
            _role = role;
        }

        [HttpPost]
        public async Task<ActionResult> AddNewRole(AddRoleDto addRoleDto)
        {
            if (addRoleDto != null)
            {
                return StatusCode(201, await _role.AddNewRole(addRoleDto));
            }
            else
            {
                return StatusCode(404, await _role.AddNewRole(addRoleDto));
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetAllUser()
        {
            return StatusCode(200, await _role.GetAllRoles());
        }
    }
}
