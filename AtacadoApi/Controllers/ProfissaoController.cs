using Atacado.Poco.Auxiliar;
using Atacado.Service.Auxiliar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfissaoController : ControllerBase
    {
        private ProfissaoService servico;

        public ProfissaoController() : base()
        {
            this.servico = new ProfissaoService();
        }

        [HttpGet]
        public List<ProfissaoPoco> GetAll()
        {
            return this.servico.Listar();
        }

        [HttpGet("{id:int}")]
        public ProfissaoPoco GetPorId(int id)
        {
            return this.servico.Selecionar(id);
        }
        [HttpPost]
        public ProfissaoPoco Post([FromBody] ProfissaoPoco poco)
        {
            return this.servico.Criar(poco);
        }
        [HttpPut]
        public ProfissaoPoco Put([FromBody] ProfissaoPoco poco)
        {
            return this.servico.Atualizar(poco);
        }
        [HttpDelete]
        public ProfissaoPoco Delete([FromBody] ProfissaoPoco poco)
        {
            return this.servico.Excluir(poco);
        }
        [HttpDelete("{id:int}")]
        public ProfissaoPoco Delete(int id)
        {
            return this.servico.Excluir(id);
        }
    }
}
