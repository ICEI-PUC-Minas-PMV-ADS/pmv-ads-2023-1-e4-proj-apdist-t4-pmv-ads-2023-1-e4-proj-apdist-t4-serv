using api_contratos_servicos.Context;
using api_contratos_servicos.Models;
using api_contratos_servicos.Models.Dto;
using api_contratos_servicos.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace api_contratos_servicos.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("login")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<UsuarioRespostaDTO>> Login([Bind("Email,Senha")]  UsuarioLogin usuario)
        {
            if (usuario == null)
            {
                return BadRequest();
            }

            if (_context.Usuarios == null)
            {
                return Unauthorized();
            }


            var usuarioLogado = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == usuario.Email);

            if (usuarioLogado == null || !BCrypt.Net.BCrypt.Verify(usuario.Senha, usuarioLogado.Senha))
            {
                System.Diagnostics.Debug.WriteLine(" nao bateu");
                return Unauthorized();
            }
            System.Diagnostics.Debug.WriteLine(" bateu");

            var token = TokenService.GenerateToken(usuarioLogado);

            return new UsuarioRespostaDTO(usuarioLogado.Id, usuarioLogado.Nome, usuarioLogado.Email, token, usuarioLogado.Role);

        }


        [Route("cadastrar")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<UsuarioRespostaDTO>> Cadastrar(UsuarioDTO usuarioDTO
            )
        {
            if (usuarioDTO == null)
            {
                return BadRequest();
            }

            if (_context.Usuarios == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Usuarios'  is null.");
            }

            if ((usuarioDTO.Tipo != "cliente") && (usuarioDTO.Tipo != "fornecedor"))
            {
                return Problem("Tipo de usario descocnhecido.");
            }
            
            //ValidaUsuario
            var usuarioCadastro = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == usuarioDTO.Email);

            if (!(usuarioCadastro == null))
            {
                return new UsuarioRespostaDTO(usuarioCadastro.Id, usuarioCadastro.Nome, usuarioCadastro.Email,usuarioCadastro.Role, null);
            }

            usuarioCadastro = new Usuario(usuarioDTO.Nome, usuarioDTO.Email, BCrypt.Net.BCrypt.HashPassword(usuarioDTO.Senha), usuarioDTO.Tipo);
            _context.Usuarios.Add(usuarioCadastro);



            Console.WriteLine("salvou cliente");
            Console.WriteLine(usuarioDTO.Tipo);

            //salvar cliente ou Fornecedor
            if (usuarioDTO.Tipo == "cliente") {
                var cliente = usuarioDTO.usuarioCliente();
                cliente.UsuarioId = usuarioCadastro.Id;

                Console.WriteLine("salvar cliente");
                Console.WriteLine(cliente);
                _context.Clientes.Add(cliente);
            } else if(usuarioDTO.Tipo == "fornecedor") {
                var fornecedor = usuarioDTO.usuarioFornecedor();
                fornecedor.UsuarioId = usuarioCadastro.Id;
                _context.Fornecedores.Add(fornecedor);
            }


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                {
                    throw;
                }
            }


            return new UsuarioRespostaDTO(usuarioCadastro.Id, usuarioCadastro.Nome, usuarioCadastro.Email, usuarioCadastro.Role, null);


        }

        
        [Route("validaUsername")]
        [HttpGet]
        public async Task<ActionResult<String>> validaUsername([Bind("email")] String email)
        {
            if (email == null)
            {
                return BadRequest();
            }

            if (_context.Usuarios == null)
            {
                return Unauthorized();
            }


            var usuarioLogado = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email);

            if (usuarioLogado == null)
            {
                return "OK";
            }

            return "Usuario já cadastrado";

        }

        [Route("alterarSenha")]
        [HttpPut]
        public async Task<ActionResult<String>> alteraSenha(UsuarioAlterarSenhaDTO usuarioSenha)
        {
            if (usuarioSenha == null)
            {
                return BadRequest();
            }

            if (_context.Usuarios == null)
            {
                return Unauthorized();
            }


            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == usuarioSenha.Email);

            if (usuario == null || !BCrypt.Net.BCrypt.Verify(usuarioSenha.AntigaSenha, usuario.Senha))
            {
                System.Diagnostics.Debug.WriteLine(" nao bateu");
                return Unauthorized();
            }

            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioSenha.NovaSenha);

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(usuario.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return "Senha alterada com sucesso!";

        }

        private string gerarSenha()
        {
            string validar = "abcdefghijklmnozABCDEFGHIJKLMNOZ1234567890@#$%&*!";
            string _senha = "";
            try
            {
                int _tamanho_senha = 8;
                StringBuilder strbld = new StringBuilder(100);
                Random random = new Random();
                while (0 < _tamanho_senha--)
                {
                    strbld.Append(validar[random.Next(validar.Length)]);
                }
                _senha = strbld.ToString();
            }
            catch (Exception ex)
            {
                _senha = "error";
            }
            return _senha;
        }


        private bool UsuarioExists(int id)
        {
            return (_context.Usuarios?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        
    }

     public class UsuarioLogin
    {
        public string Email { get; set; }

        public string Senha { get; set; }

        public Usuario usuarioDtoToUsuario()
        {
            var usuario = new Usuario();
            usuario.Email = Email;
            usuario.Senha = Senha;
            return usuario;
        }
    }

    public class UsuarioAlterarSenhaDTO
    {
        public string Email { get; set; }

        public string AntigaSenha { get; set; }

        public string NovaSenha { get; set; }



        public Usuario usuarioAlterarSenhaDTO()
        {
            var usuario = new Usuario();
            usuario.Email = Email;
            usuario.Senha = NovaSenha;
            return usuario;
        }
    }




}
