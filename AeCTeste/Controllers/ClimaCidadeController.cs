using AeCTeste.Interfaces;
using AeCTeste.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AeCTeste.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class ClimaCidadeController : ControllerBase
    {
        public readonly IClimaCidadeServices _climaCidadeServices;

        public ClimaCidadeController(IClimaCidadeServices climaCidadeServices)
        {
            _climaCidadeServices = climaCidadeServices;
        }

        [HttpGet("/cptec/v1/clima/previsao/{cityCode}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<ClimaCidadeModel>> BuscarClimaCidade(string cityCode)
        {

            return await _climaCidadeServices.BuscarClimaCidade(cityCode);

           /* if (response.CodigoHttp == HttpStatusCode.OK ) 
            
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }*/
            
        }


    }
}
