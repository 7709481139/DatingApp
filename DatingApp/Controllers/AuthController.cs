using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DatingApp.Data;
using DatingApp.Model;

namespace DatingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;

        }
        [HttpPost("register")]
        
        public async Task<IActionResult> Register(string username, string password)
        {
            username = username.ToLower();
            if (await _repo.UserExists(username))
                return BadRequest("Username is already exists");

            var userToCreate = new User { Username = username };
            var createdUser = await _repo.Register(userToCreate, password);
            return StatusCode(201);
        }
    }
}