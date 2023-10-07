using DriveXpress_refeitodozero_Annafreitask.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading.Tasks;

namespace DriveXpress_refeitodozero_Annafreitas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardapiosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CardapiosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var model = await _context.Cardapios.ToListAsync();
            return Ok(model);
        }

    }
}