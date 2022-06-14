using Atacado.EF.Database;
using Atacado.Mapper.Ancestral;
using Atacado.Poco.Estoque;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Mapper.Estoque
{
    public class ProdutoMapper : BaseAncestralMapper
    {
        public ProdutoMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Produto, ProdutoPoco>();
                //.ForMember(destPoco => destPoco.Codigo, m => m.MapFrom(dom => dom.IdProduto))
                //.ForMember(destPoco => destPoco.Descricao, m => m.MapFrom(dom => dom.DescricaoProduto));

                cfg.CreateMap<ProdutoPoco, Produto>();
                //.ForMember(destDom => destDom.IdProduto, map => map.MapFrom(poco => poco.Codigo))
                //.ForMember(destDom => destDom.DescricaoProduto, map => map.MapFrom(poco => poco.Descricao));
            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}
