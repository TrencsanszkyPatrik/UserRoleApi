using WebApplication2.Services.IServices;
using WebApplication2.Models.DtoS;
using WebApplication2.Models;
using MySqlX.XDevAPI.Common;
using Microsoft.EntityFrameworkCore;


namespace WebApplication2.Services
{
    public class RoleService : IRole
    {

        private readonly UserDbContext _context;
        public RoleService(UserDbContext context)
        {
            _context = context;
        }
        public async Task<object> AddNewRole(AddRoleDto addRoleDto)
        {
            try
            {
                var result = new ResultResponseDto();

                var role = new Role
                {
                    Id = Guid.NewGuid(),
                    Name = addRoleDto.Name
                };



                if (role != null)
                {
                    await _context.Roles.AddAsync(role);
                    await _context.SaveChangesAsync();

                    result.message = "Sikeres hozzáadás";
                    result.result = role;
                    return result;

                }

                result.message = "Sikertelen hozzáadás";
                result.result = role;
                return result;
            }
            catch (Exception ex)
            {
                var result = new ResultResponseDto();
                result.message = ex.Message;
                result.result = null;
                return result;
            }
        }

        public Task<object> DeleteRole(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetAllRoles()
        {

            try
            {
                var result = new ResultResponseDto();
                result.message = "Sikeres lekérdezés";
                result.result = await _context.Roles.ToListAsync();

                return result;
            }
            catch (Exception)
            {
                var result = new ResultResponseDto();
                result.message = "Sikertelen lekérdezés";
                result.result = null;
                return result;
            }

        }

        public Task<object> GetRoleById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<object> UpdateRole(Guid id, string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
