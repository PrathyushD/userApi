﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userCore.Models
{
    public interface IUserService
    {
         void GetUsers();

        Task<users> CreateUser(users user);

        Task<users> DeleteUser(int UserId, users users);
    }
}
