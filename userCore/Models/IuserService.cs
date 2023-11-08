using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userCore.Models
{
    public interface IUserService
    {
         Task<List<users>> getUsers();

        Task<users> createUser(users user);

        Task<users> deleteUser(int UserId, users users);
    }
}
