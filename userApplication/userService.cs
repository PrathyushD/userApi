using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userCore.Models;

namespace userApplication
{
    public class UserService : IUserService
    {
        private readonly IUsersRepository _usersRepository;
        public UserService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public Task<users> createUser(users user)
        {
            throw new NotImplementedException();
        }

        public Task<users> deleteUser(int UserId, users users)
        {
            throw new NotImplementedException();
        }

        public async Task<List<users>> getUsers()
        {
            string queryString = "select * from Users";
            List<users> users = await _usersRepository.GetUsers(queryString);
            return (users);
        }
    }
}
