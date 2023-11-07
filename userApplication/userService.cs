using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userCore.Models;

namespace userApplication
{
    public class userService : IUserService
    {
        private readonly IusersRepository _usersRepository;
        public userService(IusersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public Task<users> CreateUser(users user)
        {
            throw new NotImplementedException();
        }

        public Task<users> DeleteUser(int UserId, users users)
        {
            throw new NotImplementedException();
        }

        public Task<List<users>> GetUsers()
        {
            string queryString = "select * from users";
            List<users> users = await _usersRepository.GetUsers(queryString);
            return (users);
        }
    }
}
