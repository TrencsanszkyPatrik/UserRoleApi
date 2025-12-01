using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models.DtoS;

namespace WebApplication2.Services.IServices
{
    public interface IUser
    {
        Task<object> AddNewUser(AddUserDto addUserDto);
    }
}
