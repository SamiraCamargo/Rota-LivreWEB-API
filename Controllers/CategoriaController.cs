using Microsoft.AspNetCore.Mvc;
using Rota_LivreWEB_API.Models;
using Rota_LivreWEB_API.DbContext;

namespace Rota_LivreWEB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController: ControllerBase
    {
        private readonly ILogger<Categoria> _logger;

        public CategoriaController(ILogger<Categoria> logger)
        {
            _logger = logger;
        }

        [HttpGet("Escolher_Categoria")]

        public IActionResult EscolherCategoria(string Novo_tipo_Categoria)
        {
            Categoria NovaCategoria = new Categoria(Novo_tipo_Categoria);

            if (CategoriaDbContext.Escolher_Categoria(NovaCategoria)== "Sucesso")
            {
                return Ok("Categoria Selecionada!");
            }
            else
            {
                return BadRequest("Falha ao selecionar a categoria");
            }
        }
    }
}
