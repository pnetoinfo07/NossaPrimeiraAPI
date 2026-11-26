using Microsoft.AspNetCore.Mvc;

namespace MinhaPrimeiraAPII.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        [HttpGet("BoaNoite")]
        public string Saudacao()
        {
            return "Boa noite turma";
        }
    }
}
