using Atacado.EF.Database;
using Atacado.Mapper.Auxiliar;
using Atacado.Poco.Auxiliar;
using Atacado.Repository.Auxiliar;
using Atacado.Service.Ancestral;

namespace Atacado.Service.Auxiliar
{
    public class TipoAquiculturaService : BaseAncestralService<TipoAquiculturaPoco, TipoAquicultura>
    {
        private TipoAquiculturaMapper mapConfig;

        private TipoAquiculturaRepository repositorio;

        public TipoAquiculturaService()
        {
            this.mapConfig = new TipoAquiculturaMapper();
            this.repositorio = new TipoAquiculturaRepository(new AtacadoContext());
        }

        public List<TipoAquiculturaPoco> Listar(int pular, int exibir)
        {
            List<TipoAquicultura> listDOM = this.repositorio.Read(pular, exibir).ToList();
            return ProcessarListaDOM(listDOM);
        }
        
        protected override List<TipoAquiculturaPoco> ProcessarListaDOM(List<TipoAquicultura> listDOM)
        {
            return listDOM.Select(dom => this.mapConfig.Mapper.Map<TipoAquiculturaPoco>(dom)).ToList();
        }

        public override TipoAquiculturaPoco Selecionar(int id)
        {
            TipoAquicultura dom = this.repositorio.Read(id);
            TipoAquiculturaPoco poco = this.mapConfig.Mapper.Map<TipoAquiculturaPoco>(dom);
            return poco;
        }

        public override TipoAquiculturaPoco Atualizar(TipoAquiculturaPoco obj)
        {
            TipoAquicultura dom = this.mapConfig.Mapper.Map<TipoAquicultura>(obj);
            TipoAquicultura alterado = this.repositorio.Edit(dom);
            TipoAquiculturaPoco poco = this.mapConfig.Mapper.Map<TipoAquiculturaPoco>(alterado);
            return poco;
        }

        public override TipoAquiculturaPoco Criar(TipoAquiculturaPoco obj)
        {
            TipoAquicultura dom = this.mapConfig.Mapper.Map<TipoAquicultura>(obj);
            TipoAquicultura criado = this.repositorio.Add(dom);
            TipoAquiculturaPoco poco = this.mapConfig.Mapper.Map<TipoAquiculturaPoco>(criado);
            return poco;
        }

        public override TipoAquiculturaPoco Excluir(int id)
        {
            TipoAquicultura excluido = this.repositorio.DeleteById(id);
            TipoAquiculturaPoco poco = this.mapConfig.Mapper.Map<TipoAquiculturaPoco>(excluido);
            return poco;
        }

        public override TipoAquiculturaPoco Excluir(TipoAquiculturaPoco obj)
        {
            return this.Excluir(obj.IdTipoAquicultura);
        }
    }
}