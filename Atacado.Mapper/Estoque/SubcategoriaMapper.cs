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
    public class SubcategoriaMapper : BaseAncestralMapper
    {
        public SubcategoriaMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Subcategoria, SubcategoriaPoco>();
                //.ForMember(destPoco => destPoco.Codigo, m => m.MapFrom(dom => dom.IdSubcategoria))
                //.ForMember(destPoco => destPoco.Descricao, m => m.MapFrom(dom => dom.DescricaoSubcategoria));

                cfg.CreateMap<SubcategoriaPoco, Subcategoria>();
                    //.ForMember(destDom => destDom.IdSubcategoria, map => map.MapFrom(poco => poco.Codigo))
                    //.ForMember(destDom => destDom.DescricaoSubcategoria, map => map.MapFrom(poco => poco.Descricao));
            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}
