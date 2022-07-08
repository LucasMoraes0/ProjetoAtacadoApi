using Atacado.EF.Database;
using Atacado.Mapper.Auxiliar;
using Atacado.Poco.Auxiliar;
using Atacado.Repository.Auxiliar;
using Atacado.Service.Ancestral;

namespace Atacado.Service.Auxiliar
{
    public class AquiculturaService : BaseAncestralService<AquiculturaPoco, Aquicultura>
    {
        private AquiculturaMapper mapConfig;

        private AquiculturaRepository repositorio;

        public AquiculturaService()
        {
            this.mapConfig = new AquiculturaMapper();
            this.repositorio = new AquiculturaRepository(new AtacadoContext());
        }

        public List<AquiculturaPoco> Listar(int pular, int exibir)
        {
            List<Aquicultura> listDOM = this.repositorio.Read(pular, exibir).ToList();
            return ProcessarListaDOM(listDOM);
        }

        public List<AquiculturaPoco> ListarPorAnoeIdMun(int Ano, int idMun)
        {
            List<Aquicultura> listDOM =
                this.repositorio.Browse(aqui => (aqui.Ano == Ano) && (aqui.IdMunicipio == idMun)).ToList();
            return ProcessarListaDOM(listDOM);
        }

        protected override List<AquiculturaPoco> ProcessarListaDOM(List<Aquicultura> listDOM)
        {
            return listDOM.Select(dom => this.mapConfig.Mapper.Map<AquiculturaPoco>(dom)).ToList();
        }

        public override AquiculturaPoco Selecionar(int id)
        {
            Aquicultura dom = this.repositorio.Read(id);
            AquiculturaPoco poco = this.mapConfig.Mapper.Map<AquiculturaPoco>(dom);
            return poco;
        }

        public override AquiculturaPoco Atualizar(AquiculturaPoco obj)
        {
            Aquicultura dom = this.mapConfig.Mapper.Map<Aquicultura>(obj);
            Aquicultura alterado = this.repositorio.Edit(dom);
            AquiculturaPoco poco = this.mapConfig.Mapper.Map<AquiculturaPoco>(alterado);
            return poco;
        }

        public override AquiculturaPoco Criar(AquiculturaPoco obj)
        {
            Aquicultura dom = this.mapConfig.Mapper.Map<Aquicultura>(obj);
            Aquicultura criado = this.repositorio.Add(dom);
            AquiculturaPoco poco = this.mapConfig.Mapper.Map<AquiculturaPoco>(criado);
            return poco;
        }

        public override AquiculturaPoco Excluir(int id)
        {
            Aquicultura excluido = this.repositorio.DeleteById(id);
            AquiculturaPoco poco = this.mapConfig.Mapper.Map<AquiculturaPoco>(excluido);
            return poco;
        }

        public override AquiculturaPoco Excluir(AquiculturaPoco obj)
        {
            return this.Excluir(obj.IdAquicultura);
        }
    }
}