using Microsoft.AspNetCore.Mvc;
using Rota_LivreWEB_API.Models;
using Rota_LivreWEB_API.DbContext;

namespace Rota_LivreWEB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger <Usuario>  _logger;

        public UsuarioController(ILogger<Usuario> logger)
        {
           _logger = logger;
        }

        [HttpPost("Cadastrar_Usuario")]
        public IActionResult CadastrarUsuario(string Novo_Usuario_Nome, string Novo_Usuario_Nasc, string Novo_Usuario_Email, string Novo_Usuario_Senha)
        {
            Usuario NovoUsuario = new Usuario(Novo_Usuario_Nome,Convert.ToDateTime(Novo_Usuario_Nasc),Novo_Usuario_Email, Novo_Usuario_Senha); 

           if(UsuarioDbContext.Cadastra_Usuario(NovoUsuario) == "Sucesso")
            {
                return Ok("Cadastro concluido parabens");
            }
            else
            {
                return BadRequest("Falha ao concluir o cadastro tente novamente mais tarde");
            }
        }

        [HttpPut("Alterar_senha")]
        public IActionResult Alterar_senha(int id_usuario, string Velha_senha, string Nova_senha)
        {
            UsuarioDbContext.Alterar_senha(id_usuario,Velha_senha, Nova_senha);
            return Ok("Senha Alterada");
        }
    
    }
}
