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

    public class OrcamentosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrcamentosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Orcamentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrcamentoDTO>> GetOrcamento(int id)
        {
          if (_context.Orcamentos == null)
          {
              return NotFound();
          }
            var orcamento = _context.Orcamentos
                .Where(x => x.Id == id)
                .Include(u=> u.Usuario)
                .FirstOrDefault();


            if (orcamento == null)
            {
                return NotFound();
            }

            var pedido = _context.Pedidos
                .Where(x => x.Id == orcamento.PedidoId)
                .Include(p => p.TipoServico)
                .FirstOrDefault();

            if (pedido == null)
            {
                return NotFound();
            }

            return new OrcamentoDTO
            {
                Id = orcamento.Id,
                Pedido = pedido,
                Status = orcamento.Status,
                Data = orcamento.Data,
                ValorOrcamento = orcamento.ValorOrcamento
                
            };
        }

        [HttpGet("usuario/{id}")]
        public async Task<ActionResult<IEnumerable<OrcamentoDTO>>> GetOrcamentoUsuario(int id)
        {
            if (_context.Orcamentos == null)
            {
                return NotFound();
            }


            var orcamentos =  await _context.Orcamentos
                .Where(x => x.UsuarioId == id)
                .Include(u => u.Usuario)
                .ToListAsync();

            if (orcamentos == null)
            {
                return null;
            }

            var listaDTO = new List<OrcamentoDTO> {  };
            foreach (var orcamento in orcamentos)
            {
                var pedido = _context.Pedidos
                .Where(x => x.Id == orcamento.PedidoId)
                .Include(p => p.TipoServico)
                .FirstOrDefault();
                listaDTO.Add(new OrcamentoDTO
                {
                    Id = orcamento.Id,
                    Pedido = pedido,
                    Status = orcamento.Status,
                    Data = orcamento.Data,
                    ValorOrcamento = orcamento.ValorOrcamento

                });
            }


            return listaDTO;
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrcamento(int id, OrcamentoDTO orcamento)
        {
            if (id != orcamento.Id)
            {
                return BadRequest();
            }

            var orcamentoNovo = _context.Orcamentos
                .Where(x => x.Id == id)
                .FirstOrDefault();


            if (orcamentoNovo == null)
            {
                return NotFound();
            }

            orcamentoNovo.ValorOrcamento = orcamento.ValorOrcamento;

            _context.Entry(orcamentoNovo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrcamentoExists(id))
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
        public async Task<IActionResult> EnviarOrcamento(int id)
        {
            if (_context.Orcamentos == null)
            {
                return NotFound();
            }
            var orcamento = _context.Orcamentos
                .Where(p => p.Id == id)
                .FirstOrDefault();

            if (orcamento == null)
            {
                return NotFound();
            }

            orcamento.Status = "Orcado";

            var pedido = _context.Pedidos
                .Where(p => p.Id == orcamento.PedidoId)
                .FirstOrDefault();

            if (pedido == null)
            {
                return NotFound();
            }

            pedido.Status = "Orcado";


            _context.Entry(orcamento).State = EntityState.Modified;

            _context.Entry(pedido).State = EntityState.Modified;


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrcamentoExists(id))
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


        private bool OrcamentoExists(int id)
        {
            return (_context.Orcamentos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
