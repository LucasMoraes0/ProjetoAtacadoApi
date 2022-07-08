

using Atacado.Envelope.Ancestral;
using Newtonsoft.Json;

namespace Atacado.Envelope.RH
{
    public class EmpresaEnvelopeJSON : BaseEnvelopeJSON
    {
        [JsonProperty(PropertyName = "idempresa")]
        public int Codigo { get; set; }

        [JsonProperty(PropertyName = "razaosocial")]
        public string RazaoSocial { get; set; }

        [JsonProperty(PropertyName = "nomefantasia")]
        public string NomeFantasia { get; set; }

        [JsonProperty(PropertyName = "cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty(PropertyName = "ie")]
        public string InscricaoEstadual { get; set; }

        [JsonProperty(PropertyName = "telefone")]
        public string Telefone { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "endereco")]
        public string Endereco { get; set; }

        public override void SetLinks()
        {
            this.Links.List = "GET /empresa";
            this.Links.Self = "GET /empresa" + this.Codigo.ToString();
            this.Links.Exclude = "GET /empresa" + this.Codigo.ToString();
            this.Links.Update = "GET /empresa" + this.Codigo.ToString();
            this.Links.Create = "GET /empresa" + this.Codigo.ToString();
        }
    }
}
