﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NBA_API.DAL;

namespace NBA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadorController : ControllerBase
    {
        private readonly Context _context;

        public JugadorController(Context context)
        {
            _context = context;
        }

        private bool JugadorExists(int id)
        {
            return _context.Jugador.Any(j => j.JugadorId == id);
        }

        // GET: api/Jugadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jugador>>> GetJugadores()
        {
            return await _context.Jugador.ToListAsync();
        }

        // GET: api/Jugador/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jugador>> GetJugador(int id)
        {
            var jugador = await _context.Jugador.FindAsync(id);

            if (jugador == null)
            {
                return NotFound();
            }

            return jugador;
        }

        // GET : api/Jugador/Equipo/5
        [HttpGet("Equipo/{equipoId}")]
        public async Task<ActionResult<IEnumerable<Jugador>>> GetJugadoresByEquipo(int equipoId)
        {
            var jugadores = await _context.Jugador.Where(j => j.EquipoId == equipoId).ToListAsync();

            if(jugadores == null || !jugadores.Any())
            {
                return NotFound();
            }

            return jugadores;
        }

        // POST: api/Jugador
        [HttpPost]
        public async Task<ActionResult<Jugador>> PostJugador(Jugador jugador)
        {
            if (!JugadorExists(jugador.JugadorId))
            {
                _context.Jugador.Add(jugador);
            }
            else
            {
                _context.Jugador.Update(jugador);
            }

            await _context.SaveChangesAsync();
            return Ok(jugador);
        }

        // DELETE: api/Jugador/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJugador(int id)
        {
            var jugador = await _context.Jugador.FindAsync(id);
            if (jugador == null)
            {
                return NotFound();
            }

            _context.Jugador.Remove(jugador);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
