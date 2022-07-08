using Atacado.EF.Database;
using Atacado.Mapper.Ancestral;
using Atacado.Poco.Auxiliar;
using AutoMapper;

namespace Atacado.Mapper.Auxiliar
{
    public class TipoAquiculturaMapper : BaseAncestralMapper
    {
        public TipoAquiculturaMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoAquicultura, TipoAquiculturaPoco>();

                cfg.CreateMap<TipoAquiculturaPoco, TipoAquicultura>();
            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}