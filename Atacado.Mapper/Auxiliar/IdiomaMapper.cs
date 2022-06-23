using Atacado.EF.Database;
using Atacado.Mapper.Ancestral;
using Atacado.Poco.Auxiliar;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Mapper.Auxiliar
{
    public class IdiomaMapper : BaseAncestralMapper
    {
        public IdiomaMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Idioma, IdiomaPoco>();
                //.ForMember(destPoco => destPoco.Codigo, m => m.MapFrom(dom => dom.IdIdioma))
                //.ForMember(destPoco => destPoco.Descricao, m => m.MapFrom(dom => dom.DescricaoIdioma));

                cfg.CreateMap<IdiomaPoco, Idioma>();
                //.ForMember(destDom => destDom.IdIdioma, map => map.MapFrom(poco => poco.Codigo))
                //.ForMember(destDom => destDom.DescricaoIdioma, map => map.MapFrom(poco => poco.Descricao));
            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}
