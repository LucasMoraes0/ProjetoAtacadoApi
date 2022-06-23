using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Auxiliar
{
    public class BancoPoco
    {
        public int IdBanco { get; set; }       
        public int? CodBanco { get; set; }       
        public string? DescricaoBanco { get; set; }        
        public string? SiteBanco { get; set; }
        public bool? Situacao { get; set; }
    }
}
