using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace A91WEBERP.API.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
     public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }
        // GET: api/student
    [HttpGet]
          public async Task<IActionResult>Get()
        {
            //
            var values =await _context.Values.ToListAsync();
            return Ok(values);
        }

        // GET: api/student/5
         [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var value = await _context.Values.Where(t => t.Id == id).FirstOrDefaultAsync();
            return Ok(value);
        }

        // POST: api/student
[HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/student/5
          [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/student/5
          [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
