using System.Threading.Tasks;
using WebApplication2.Models.DtoS;

namespace WebApplication2.Services.IServices

{
    public interface IUserRole
    {
        Task<object> AddNewConnection(AddUserRoleDto addUserRoleDto);
    }
}
