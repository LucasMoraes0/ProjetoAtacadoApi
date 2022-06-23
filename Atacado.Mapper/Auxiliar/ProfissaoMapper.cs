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
    public class ProfissaoMapper : BaseAncestralMapper
    {
        public ProfissaoMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Profissao, ProfissaoPoco>();
                //.ForMember(destPoco => destPoco.Codigo, m => m.MapFrom(dom => dom.IdProfissao))
                //.ForMember(destPoco => destPoco.Descricao, m => m.MapFrom(dom => dom.DescricaoProfissao));

                cfg.CreateMap<ProfissaoPoco, Profissao>();
                //.ForMember(destDom => destDom.IdProfissao, map => map.MapFrom(poco => poco.Codigo))
                //.ForMember(destDom => destDom.DescricaoProfissao, map => map.MapFrom(poco => poco.Descricao));
            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}
