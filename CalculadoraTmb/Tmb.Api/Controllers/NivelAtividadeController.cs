using Microsoft.AspNetCore.Mvc;
using Tmb.Domain.Entidades;
using Tmb.Domain.StaticData;

namespace Tmb.Api.Controllers
{
    [ApiController]
    [Route("api/niveis-atividade")]
    public class NivelAtividadeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<NivelDeAtividade>> ObterTodos()
        {
            var niveis = NivelDeAtividadeData.ObterTodos();
            return Ok(niveis);
        }

    }
}
