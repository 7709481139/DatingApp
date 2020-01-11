using DatingApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string Password);
        Task<User> Login(string Username, string Password);
        Task<bool> UserExists(string Username);
    }
}
