using Atacado.EF.Database;
using Atacado.Mapper.Ancestral;
using Atacado.Poco.Auxiliar;
using AutoMapper;

namespace Atacado.Mapper.Auxiliar
{
    public class AquiculturaMapper : BaseAncestralMapper
    {
        public AquiculturaMapper()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Aquicultura, AquiculturaPoco>();

                cfg.CreateMap<AquiculturaPoco, Aquicultura>();
            });
            this.getMapper = configuration.CreateMapper();
        }
    }
}