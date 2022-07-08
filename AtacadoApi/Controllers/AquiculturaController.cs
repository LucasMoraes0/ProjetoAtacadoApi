using Atacado.Poco.Auxiliar;
using Atacado.Service.Auxiliar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtacadoApi.Controllers
{
    /// <summary>
    /// Recurso Aquicultura.
    /// </summary>
    [Route("api/auxiliar/[controller]")]
    [ApiController]
    public class AquiculturaController : ControllerBase
    {
        private AquiculturaService servico;
        /// <summary>
        /// Construtor da classe.
        /// </summary>
        public AquiculturaController() : base()
        {
            this.servico = new AquiculturaService();
        }
        /// <summary>
        /// Faz a  busca por todos os registros filtrando onde inicia (skip) e a quantidade a sser buscada(take).
        /// </summary>
        /// <param name="skip">Onde inicia os resultados da pesquisa.</param>
        /// <param name="take">Quantos registros serão retornados.</param>
        /// <returns>Coleção de dados.</returns>
        /// 
        [HttpGet("{skip:int}/{take:int}")]
        public ActionResult<List<AquiculturaPoco>> Get(int skip, int take)
        {
            try
            {
                List<AquiculturaPoco> listaResposta = this.servico.Listar(skip, take);
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
        public ActionResult<AquiculturaPoco> Post([FromBody] AquiculturaPoco poco)
        {
            try
            {
                AquiculturaPoco pocoResposta = this.servico.Criar(poco);
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
        public ActionResult<AquiculturaPoco> Put([FromBody] AquiculturaPoco poco)
        {
            try
            {
                AquiculturaPoco pocoResposta = this.servico.Atualizar(poco);
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
        public ActionResult<AquiculturaPoco> Delete([FromBody] AquiculturaPoco poco)
        {
            try
            {
                AquiculturaPoco pocoResposta = this.servico.Excluir(poco);
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
        public ActionResult<AquiculturaPoco> Delete(int id)
        {
            try
            {
                AquiculturaPoco pocoResposta = this.servico.Excluir(id);
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
        public ActionResult<AquiculturaPoco> GetByID(int id)
        {
            try
            {
                AquiculturaPoco pocoResposta = this.servico.Selecionar(id);
                return Ok(pocoResposta);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
        /// <summary>
        /// Busca de Objeto Por Ano Referencia e ID de Municipio.
        /// </summary>
        /// <param name="anoRef">Ano Referencia a ser pesquisado</param>
        /// <param name="idMun">ID municipio a ser pesquisado</param>
        /// <returns>Coleção de dados.</returns>
        [HttpGet("anoref/{anoRef:int}/idmun/{idMun:int}")]
        public ActionResult<List<AquiculturaPoco>> GetPorAnoRefIdMun(int anoRef, int idMun)
        {
            try
            {
                List<AquiculturaPoco> lista = this.servico.ListarPorAnoeIdMun(anoRef, idMun);
                return Ok(lista);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
    }
}