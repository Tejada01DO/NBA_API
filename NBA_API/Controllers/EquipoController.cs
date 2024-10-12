using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NBA_API.DAL;

namespace NBA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        private readonly Context _context;

        public EquipoController(Context context)
        {
            _context = context;
        }

        private bool EquipoExists(int id)
        {
            return _context.Equipo.Any(e => e.EquipoId == id);
        }

        // GET: api/Equipos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipo>>> GetEquipos()
        {
            return await _context.Equipo.ToListAsync();
        }

        // GET: api/Equipo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Equipo>> GetEquipo(int id)
        {
            var equipo = await _context.Equipo.FindAsync(id);

            if (equipo == null)
            {
                return NotFound();
            }

            return equipo;
        }
    }
}
