using Atacado.Envelope.Ancestral;
using Newtonsoft.Json;

namespace Atacado.Envelope.Auxiliar
{
    public class TipoAquiculturaEnvelopeJSON
    {
        [JsonProperty(PropertyName = "IdTipoAquicultura")]
        public int IdTipoAquicultura { get; set; }

        [JsonProperty(PropertyName = "DescricaoTipoAquicultura")]
        public string DescricaoTipoAquicultura { get; set; }

        [JsonProperty(PropertyName = "Situacao")]
        public bool? Situacao { get; set; }

        public override void SetLinks()
        {
            this.Links.List = "GET/TipoAquicultura";
            this.
        }
    }
}
