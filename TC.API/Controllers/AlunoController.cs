using Microsoft.AspNetCore.Mvc;
using TC.Data.Repository.Interfaces;
using TC.Domain;

namespace TC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoController(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_alunoRepository.Get());
        }

        [HttpPost]
        public IActionResult Add(Aluno aluno)
        {
            _alunoRepository.Post(aluno);
            return StatusCode(201);
        }
    }
}
