using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPII.Services;

namespace MinhaPrimeiraAPII.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        [HttpGet("Listar")]
        public List<string> Listar()
        {
            return ProdutoService.Produtos;
        }
        [HttpPost("New")]
        public string Adicionar(string descricao)
        {
            ProdutoService.Adicionar(descricao);
            return "Produto adicionado com sucesso";
        }
    }
}
