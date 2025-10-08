using Microsoft.AspNetCore.Mvc;
using Tmb.Application.DTOs;
using Tmb.Application.Services;

namespace Tmb.Api.Controllers
{
    [ApiController]
    [Route("api/imc")]
    public class ImcController : ControllerBase
    {
        private readonly CalculadoraImcService _calculadoraImcService;

        public ImcController(CalculadoraImcService calculadoraImcService)
        {
            _calculadoraImcService = calculadoraImcService;
        }

        [HttpPost("calcular")]
        public IActionResult Calcular([FromBody] ImcRequestDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var resultado = _calculadoraImcService.CalcularImc(dto.Peso, dto.Altura);
            return Ok(new ImcResponseDto { Imc = Math.Round(resultado, 2) });
        }
    }
}
