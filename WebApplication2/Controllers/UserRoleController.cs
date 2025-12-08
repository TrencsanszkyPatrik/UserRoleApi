using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models.DtoS;
using WebApplication2.Services.IServices;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRole _userrole;
        public UserRoleController(IUserRole user)
        {
            _userrole = user;
        }

        [HttpPost]
        public async Task<ActionResult> AddNewUserRole(AddUserRoleDto addUserRoleDto)
        {
            var newuserrole = await _userrole.AddNewConnection(addUserRoleDto);
            if (newuserrole != null)
            {
                return StatusCode(201, newuserrole);
            }

            return StatusCode(404, null);

        }
    }
}