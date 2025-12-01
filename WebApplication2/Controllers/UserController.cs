using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models.DtoS;
using WebApplication2.Services.IServices;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }
        [HttpPost]
        public async Task<ActionResult> AddNewUser(AddUserDto addUserDto)
        {
            if (addUserDto != null)
            {
                return StatusCode(201, await _user.AddNewUser(addUserDto));
            } else
            {
                return StatusCode(404, await _user.AddNewUser(addUserDto));
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetAllUser()
        {
            return StatusCode(200, await _user.GetAllUser());
        }
    }
}
