using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Auxiliar
{
    public class AquiculturaPoco
    {
        public int IdAquicultura { get; set; }

        public int Ano { get; set; }

        public int IdMunicipio { get; set; }

        public int IdTipoAquicultura { get; set; }

        public string? Producao { get; set; }

        public int? ValorProducao { get; set; }
    
        public int? ProporcaoValorProducao { get; set; }

        public string Moeda { get; set; }

    }
}