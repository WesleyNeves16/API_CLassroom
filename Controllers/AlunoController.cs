using Microsoft.AspNetCore.Mvc;
using ClassroomRegistration.Domain.Data;
using ClassroomRegistration.Domain.Adapter;
using ClassroomRegistration.Domain.Functions;

namespace ClassroomRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoCRUD alunoCRUD;
        private readonly AlunoAdapter alunoAdapter;

        public AlunoController()
        {
            this.alunoAdapter = new AlunoAdapter();
            this.alunoCRUD = new AlunoCRUD(this.alunoAdapter);
        }

        // GET: api/<AlunoController>
        [HttpGet]
        public List<AlunoDomain> Get()
        {
            return this.alunoCRUD.ReadAll();
        }

        // GET api/<AlunoController>/5
        [HttpGet("{codigo}")]
        public AlunoDomain Get(int codigo)
        {
            return this.alunoCRUD.Read(codigo);
        }

        // POST api/<AlunoController>
        [HttpPost]
        public AlunoDomain Post([FromBody] AlunoDomain aluno)
        {
            return this.alunoCRUD.Insert(this.alunoAdapter.ObjectToData(aluno));
        }

        // PUT api/<AlunoController>/5
        [HttpPut]
        public AlunoDomain Put([FromBody] AlunoDomain aluno)
        {
            return this.alunoCRUD.Update(this.alunoAdapter.ObjectToData(aluno));
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete]
        public bool Delete(AlunoDomain aluno)
        {
            return this.alunoCRUD.Delete(this.alunoAdapter.ObjectToData(aluno));
        }
    }
}
