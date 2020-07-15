using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using clase_7.Models;

namespace clase_7.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {

        private readonly DataBaseContext _context;
        public TestController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Test
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Item>>> GetItems()
        {
            var item = new Item {
              Name = "Coca Cola",
              Description = "Cola Cola vidrio",
              Price = 1000,
              Category = "Bebidas"
            };
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
            return await _context.Items.ToListAsync();
        }
    }
}
