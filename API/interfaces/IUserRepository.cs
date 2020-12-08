using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;

namespace API.interfaces
{
    public interface IUserRepository
    {
        void upload(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUserNameAsync(string username);
    }
}