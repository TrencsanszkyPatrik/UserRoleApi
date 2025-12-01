using WebApplication2.Models.DtoS;

namespace WebApplication2.Services.IServices
{
    public interface IRole
    {
        Task<object> AddNewRole(AddRoleDto addRoleDto);
        Task<object> GetAllRoles();
        Task<object> GetRoleById(Guid id);
        Task<object> UpdateRole(Guid id, string roleName);
        Task<object> DeleteRole(Guid id);
    }
}
