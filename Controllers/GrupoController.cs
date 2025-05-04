using Microsoft.AspNetCore.Mvc;
using Rota_LivreWEB_API.DbContext;
using Rota_LivreWEB_API.Models;

namespace Rota_LivreWEB_API.Controllers
{
    public class GrupoController : ControllerBase
    {
        private readonly ILogger<Grupo> _logger;

        public GrupoController(ILogger<Grupo> logger)
        {
            _logger = logger;
        }

        [HttpPost("Cadastrar_Grupo")]
        
        public IActionResult Cadastrar_Grupo(string NovoLinkGrupo)
        {
            Grupo NovoGrupo = new Grupo(NovoLinkGrupo);

            if (GrupoDbContext.Cadastrar_Grupo(NovoGrupo) == "Sucesso")
            {
                return Ok("Link do grupo cadastrado!");
            }
            else
            {
                return BadRequest("Falha ao Conectar com o grupo");
            }
        }
    }
}
