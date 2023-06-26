using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api_contratos_servicos.Context;
using api_contratos_servicos.Models;
using Microsoft.AspNetCore.Authorization;
using api_contratos_servicos.Models.Dto;

namespace api_contratos_servicos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PedidosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PedidosController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        // GET: api/Pedidos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pedido>> GetPedido(int id)
        {
          if (_context.Pedidos == null)
          {
              return NotFound();
          }
            //var pedido = await _context.Pedidos.FindAsync(id);

            var pedido = _context.Pedidos
                .Where(p => p.Id == id)
                .Include(p => p.TipoServico)
                .FirstOrDefault();

            if (pedido == null)
            {
                return NotFound();
            }

            return pedido;
        }

        // GET: api/Pedidos/5
        [HttpGet("usuario/{id}")]
        public async Task<ActionResult<IEnumerable<Pedido>>> GetPedidoUsuario(int id)
        {
            if (_context.Pedidos == null)
            {
                return NotFound();
            }
            

            return await _context.Pedidos
                .Where(x => x.UsuarioId == id)
                .Include(p => p.TipoServico)
                .ToListAsync();
        }

        // PUT: api/Pedidos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedido(int id, Pedido pedido)
        {
            if (id != pedido.Id)
            {
                return BadRequest();
            }

            _context.Entry(pedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }



        [HttpPost("{id}/enviar")]
        public async Task<IActionResult> EnviarPedido(int id)
        {
            if (_context.Pedidos == null)
            {
                return NotFound();
            }
            var pedido = _context.Pedidos
                .Where(p => p.Id == id)
                .FirstOrDefault();

            if (pedido == null)
            {
                return NotFound();
            }

            pedido.Status = "Pendente";

            _context.Entry(pedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}/cancelar")]
        public async Task<IActionResult> CancelarPedido(int id)
        {
            if (_context.Pedidos == null)
            {
                return NotFound();
            }
            var pedido = _context.Pedidos
                .Where(p => p.Id == id)
                .FirstOrDefault();

            if (pedido == null)
            {
                return NotFound();
            }

            pedido.Status = "Cancelado";

            _context.Entry(pedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Pedidos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pedido>> PostPedido(PedidoDTO pedido)
        {
          if (_context.Pedidos == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Pedidos'  is null.");
          }
            var newPedido = new Pedido
            {
                Status = "Novo",
                Data = DateTime.UtcNow,
                TipoServicoId = pedido.TipoServico.Id,
                Descricao = pedido.Descricao,
                UsuarioId = pedido.UsuarioId
            };

            _context.Pedidos.Add(newPedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPedido", new { id = newPedido.Id }, newPedido);
        }

        private bool PedidoExists(int id)
        {
            return (_context.Pedidos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
