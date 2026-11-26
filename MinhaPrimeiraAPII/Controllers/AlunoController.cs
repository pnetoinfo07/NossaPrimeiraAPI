using Microsoft.AspNetCore.Mvc;

namespace MinhaPrimeiraAPII.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        [HttpGet("BoaNoite")]
        public string Saudacao()
        {
            return "Boa noite turma";
        }
        [HttpGet("BomDia")]
        public string Tarde()
        {
            return "Boa noite turma";
        }
        [HttpGet("BoaTarde")]
        public string Noite()
        {
            return "Boa noite turma";
        }
    }
}
