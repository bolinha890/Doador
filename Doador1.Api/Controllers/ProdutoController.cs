using Doador.Domain.commands;
using Doador.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Doador1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {

            _produtoService = produtoService;
        }

        [HttpPost]
        [Route("CadastrarProduto")]

        public async Task<IActionResult> postAsync([FromBody] ProdutoCommand command)
        {
            await _produtoService.postAsync (command);
            return Ok();
        }

    }
}
