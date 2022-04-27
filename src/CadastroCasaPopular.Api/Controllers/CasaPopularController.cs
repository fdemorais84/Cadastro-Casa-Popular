using System.Threading.Tasks;
using CadastroCasaPopular.Api.ViewModel;
using CasaPopular.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CasaPopular.Api.Controllers
{    
    public class CasaPopularController : ControllerBase
    {
        public readonly ICasaPopularService _casaPopularService;

        public CasaPopularController(ICasaPopularService casaPopularService)
        {            
            _casaPopularService = casaPopularService;
        }

        [HttpPost("api/cadastrar-familia")]
        public async Task<IActionResult> CadastrarFamilia([FromBody] FamiliaViewModel dados)
        {   
            return Ok(await _casaPopularService.CadastrarFamilia(dados));
        }

        [HttpGet("api/listar-familias")]
        public async Task<IActionResult> ConsultarFamilias()
        {
            return Ok(await _casaPopularService.ConsultarFamilias());
        }
    }
}
