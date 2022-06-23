using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Poco.Auxiliar
{
   public class ProfissaoPoco
    {
        public int IdProfissao { get; set; }        
        public string DescricaoProfissao { get; set; } = null!;
        public bool Situacao { get; set; }
    }
}
