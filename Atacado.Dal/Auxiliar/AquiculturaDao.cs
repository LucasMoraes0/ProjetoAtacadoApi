using Atacado.Dal.Ancestral;
using Atacado.EF.Database;
using System.Linq.Expressions;

namespace Atacado.Dal.Auxiliar
{
    public class AquiculturaDao : BaseAncestralDao<Aquicultura>
    {
        public AquiculturaDao() : base()
        { }

        public override Aquicultura Create(Aquicultura obj)
        {
            this.contexto.Aquiculturas.Add(obj);
            this.contexto.SaveChanges();
            return obj;
        }

        public override Aquicultura Delete(int id)
        {
            Aquicultura del = this.Read(id);
            this.contexto.Aquiculturas.Remove(del);
            this.contexto.SaveChanges();
            return del;
        }

        public override Aquicultura Delete(Aquicultura obj)
        {
            return this.Delete(obj.IdAquicultura);
        }

        public override Aquicultura Read(int id)
        {
            Aquicultura obj = this.contexto.Aquiculturas.SingleOrDefault(aqui => aqui.IdAquicultura == id);
            return obj;
        }

        public override List<Aquicultura> ReadAll()
        {
            return null;
        }

        public List<Aquicultura> ReadAll(int skip, int take)
        {
            return this.contexto.Aquiculturas.Skip(skip).Take(take).ToList();
        }

        public IQueryable<Aquicultura> QueryBy(Expression<Func<Aquicultura, bool>> predicado)
        {
            return this.contexto.Aquiculturas.Where(predicado);
        }

        public override Aquicultura Update(Aquicultura obj)
        {
            Aquicultura alt = this.Read(obj.IdAquicultura);
            alt.ValorProducao = obj.ValorProducao;          
            alt.ProporcaoValorProducao = obj.ProporcaoValorProducao;
            alt.Moeda = obj.Moeda;         
            this.contexto.SaveChanges();
            return alt;
        }
    }
}