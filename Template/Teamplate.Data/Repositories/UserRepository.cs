using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Domain.DTOs;
using Template.Domain.Interfaces;
using Template.Domain.Models;

namespace Template.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users = new List<User> {
            new User { Id = 1, Username = "rick", Password = "rick", Role = "manager" },
            new User { Id = 2, Username = "morty", Password = "morty", Role = "employee" }
        };

        public Task<User> Get(UserDTO userInfo)
        {
            return Task.FromResult(_users.Where(x => x.Username.ToLower() == userInfo.Username.ToLower() && x.Password == userInfo.Password).FirstOrDefault());
        }
    }
}
