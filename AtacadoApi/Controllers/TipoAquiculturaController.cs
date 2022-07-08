using Atacado.Poco.Auxiliar;
using Atacado.Service.Auxiliar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// Recurso TipoAquicultura.
    /// </summary>
    [Route("api/auxiliar/[controller]")]
    [ApiController]
    public class TipoAquiculturaController : ControllerBase
    {
        private TipoAquiculturaService servico;
        /// <summary>
        /// Construtor da classe.
        /// </summary>
        public TipoAquiculturaController() : base()
        {
            this.servico = new TipoAquiculturaService();
        }
        /// <summary>
        /// Faz a  busca por todos os registros filtrando onde inicia (skip) e a quantidade a sser buscada(take).
        /// </summary>
        /// <param name="skip">Onde inicia os resultados da pesquisa.</param>
        /// <param name="take">Quantos registros serão retornados.</param>
        /// <returns>Coleção de dados.</returns>
        /// 
        [HttpGet("{skip:int}/{take:int}")]
        public ActionResult<List<TipoAquiculturaPoco>> Get(int skip, int take)
        {
            try
            {
                List<TipoAquiculturaPoco> listaResposta = this.servico.Listar(skip, take);
                return Ok(listaResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
        /// <summary>
        /// Novo Objeto.
        /// </summary>
        /// <param name = "poco" >O Objeto criado.</param>
        /// <returns>O Objeto salvo no banco de dados.</returns>
        /// 
        [HttpPost]
        public ActionResult<TipoAquiculturaPoco> Post([FromBody] TipoAquiculturaPoco poco)
        {
            try
            {
                TipoAquiculturaPoco pocoResposta = this.servico.Criar(poco);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        /// <summary>
        /// Alterar ou Atualizar um Objeto.
        /// </summary>
        /// <param name="poco">Objeto que será alterado ou atualizado.</param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<TipoAquiculturaPoco> Put([FromBody] TipoAquiculturaPoco poco)
        {
            try
            {
                TipoAquiculturaPoco pocoResposta = this.servico.Atualizar(poco);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }

        }
        /// <summary>
        /// Deleta um objeto da tabela.
        /// </summary>
        /// <param name="poco">Dado a ser deletado.</param>
        /// <returns>Objeto será totalmente deletado do banco de dados.</returns>
        [HttpDelete]
        public ActionResult<TipoAquiculturaPoco> Delete([FromBody] TipoAquiculturaPoco poco)
        {
            try
            {
                TipoAquiculturaPoco pocoResposta = this.servico.Excluir(poco);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }

        }
        /// <summary>
        /// Objeto será deletado pelo seu ID.
        /// </summary>
        /// <param name="id">ID do Objeto que será deletado.</param>
        /// <returns>Objeto deletado do banco de dados.</returns>
        [HttpDelete("{id:int}")]
        public ActionResult<TipoAquiculturaPoco> Delete(int id)
        {
            try
            {
                TipoAquiculturaPoco pocoResposta = this.servico.Excluir(id);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
        /// <summary>
        /// Busca de Objeto pelo seu ID.
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Objeto pesquisado pelo ID.</returns>
        [HttpGet("{id:int}")]
        public ActionResult<TipoAquiculturaPoco> GetByID(int id)
        {
            try
            {
                TipoAquiculturaPoco pocoResposta = this.servico.Selecionar(id);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }              
    }
}