using System.Linq.Expressions;
using Atacado.Dal.Ancestral;
using Atacado.EF.Database;


namespace Atacado.Dal.Auxiliar
{
    public class TipoAquiculturaDao : BaseAncestralDao<TipoAquicultura>
    {
        public TipoAquiculturaDao() : base()
        { }

        public override TipoAquicultura Create(TipoAquicultura obj)
        {
            this.contexto.TipoAquiculturas.Add(obj);
            this.contexto.SaveChanges();
            return obj;
        }

        public override TipoAquicultura Delete(int id)
        {
            TipoAquicultura del = this.Read(id);
            this.contexto.TipoAquiculturas.Remove(del);
            this.contexto.SaveChanges();
            return del;
        }

        public override TipoAquicultura Delete(TipoAquicultura obj)
        {
            return this.Delete(obj.IdTipoAquicultura);
        }       

        public override TipoAquicultura Read(int id)
        {
            TipoAquicultura obj = this.contexto.TipoAquiculturas.SingleOrDefault(reb => reb.IdTipoAquicultura == id);
            return obj;
        }

        public override List<TipoAquicultura> ReadAll()
        {
            return this.contexto.TipoAquiculturas.ToList();
        }

        public List<TipoAquicultura> ReadAll(int skip, int take)
        {
            return this.contexto.TipoAquiculturas.Skip(skip).Take(take).ToList();
        }

        public IQueryable<TipoAquicultura> QueryBy(Expression<Func<TipoAquicultura, bool>> predicado)
        {
            return this.contexto.TipoAquiculturas.Where(predicado);
        }

        public override TipoAquicultura Update(TipoAquicultura obj)
        {
            TipoAquicultura alt = this.Read(obj.IdTipoAquicultura);
            alt.DescricaoTipoAquicultura = obj.DescricaoTipoAquicultura;           
            this.contexto.SaveChanges();
            return alt;
        }
    }
}