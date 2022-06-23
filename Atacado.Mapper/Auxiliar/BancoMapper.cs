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
    public class BancoMapper : BaseAncestralMapper
    {
        public BancoMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Banco, BancoPoco>();
                //.ForMember(destPoco => destPoco.Codigo, m => m.MapFrom(dom => dom.IdBanco))
                //.ForMember(destPoco => destPoco.Descricao, m => m.MapFrom(dom => dom.DescricaoBanco));

                cfg.CreateMap<BancoPoco, Banco>();
                //.ForMember(destDom => destDom.IdBanco, map => map.MapFrom(poco => poco.Codigo))
                //.ForMember(destDom => destDom.DescricaoBanco, map => map.MapFrom(poco => poco.Descricao));
            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}
