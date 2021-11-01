using System.Threading.Tasks;
using Template.Domain.DTOs;
using Template.Domain.Models;

namespace Template.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Get(UserDTO userInfo);
    }
}
