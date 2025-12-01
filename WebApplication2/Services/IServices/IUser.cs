using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models.DtoS;

namespace WebApplication2.Services.IServices
{
    public interface IUser
    {
        Task<object> AddNewUser(AddUserDto addUserDto);
        Task<object> GetAllUser();
        Task<object> GetUserById(Guid id);
        Task<object> UpdateUser(Guid id, UpdateUserDto updateUserDto);
        Task<object> DeleteUser(Guid id);
    }
}
