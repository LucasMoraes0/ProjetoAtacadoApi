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
    public class CursoMapper : BaseAncestralMapper
    {
        public CursoMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Curso, CursoPoco>();
                //.ForMember(destPoco => destPoco.Codigo, m => m.MapFrom(dom => dom.IdCurso))
                //.ForMember(destPoco => destPoco.Descricao, m => m.MapFrom(dom => dom.DescricaoCurso));

                cfg.CreateMap<CursoPoco, Curso>();
                //.ForMember(destDom => destDom.IdCurso, map => map.MapFrom(poco => poco.Codigo))
                //.ForMember(destDom => destDom.DescricaoCurso, map => map.MapFrom(poco => poco.Descricao));
            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}
