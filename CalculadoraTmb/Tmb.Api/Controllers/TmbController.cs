using Microsoft.AspNetCore.Mvc;
using Tmb.Application.DTOs;
using Tmb.Application.Services;

namespace Tmb.Api.Controllers
{
    [ApiController]
    [Route("api/tmb")]
    public class TmbController : ControllerBase
    {
        private readonly TmbCalculadoraService _service;
        public TmbController(TmbCalculadoraService service)
        {
            _service = service;
        }

        [HttpPost("calcular")]
        public IActionResult Calcular([FromBody] TmbRequestDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var resultado = _service.CalcularTmb(dto.Idade, dto.Peso, dto.Altura, dto.Sexo, dto.NivelDeAtividade);
            return Ok(new TmbResponseDto { Tmb = resultado });
        }
    }
}
