using Microsoft.AspNetCore.Mvc;
using ClassroomRegistration.Domain.Data;
using ClassroomRegistration.Domain.Adapter;
using ClassroomRegistration.Domain.Functions;

namespace ClassroomRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvaController : ControllerBase
    {
        private readonly ProvaCRUD provaCRUD;
        private readonly ProvaAdapter provaAdapter;

        public ProvaController()
        {
            this.provaAdapter = new ProvaAdapter();
            this.provaCRUD = new ProvaCRUD(this.provaAdapter);
        }

        // GET: api/<ProvaController>
        [HttpGet]
        public List<ProvaDomain> Get()
        {
            return this.provaCRUD.ReadAll();
        }

        // GET api/<ProvaController>/5
        [HttpGet("{codigo}")]
        public ProvaDomain Get(int codigo)
        {
            return this.provaCRUD.Read(codigo);
        }

        // POST api/<ProvaController>
        [HttpPost]
        public ProvaDomain Post([FromBody] ProvaDomain prova)
        {
            return this.provaCRUD.Insert(this.provaAdapter.ObjectToData(prova));
        }

        // PUT api/<ProvaController>/5
        [HttpPut]
        public ProvaDomain Put([FromBody] ProvaDomain prova)
        {
            return this.provaCRUD.Update(this.provaAdapter.ObjectToData(prova));
        }

        // DELETE api/<ProvaController>/5
        [HttpDelete]
        public bool Delete(ProvaDomain prova)
        {
            return this.provaCRUD.Delete(this.provaAdapter.ObjectToData(prova));
        }
    }
}
