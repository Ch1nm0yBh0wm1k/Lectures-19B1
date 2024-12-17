using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DataAccessLayer;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly AppDbContext _context;
        public MyController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _context.misProduct.ToListAsync();
            return Ok(data);
        }
        [HttpPut]
        public async Task<IActionResult> Post(Product prod)
        {
            _context.misProduct.Remove(prod);
            await  _context.SaveChangesAsync();

            return Ok("Done");
        }
    }
}
