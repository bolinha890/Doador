using Doador.Domain.commands;
using Doador.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Doador1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoadorControler : ControllerBase
    {
        private readonly IDoadorService _doadorservice;

        public DoadorControler(IDoadorService doadorservice)
        {
            _doadorservice = doadorservice;
        }

        [HttpPost]
        [Route("cadastrardoador")]
        public async Task<IActionResult> postAsync([FromBody] DoadorCommand command)
        {
            await _doadorservice.postAsync(command);
            return Ok();
        }
     }
}
