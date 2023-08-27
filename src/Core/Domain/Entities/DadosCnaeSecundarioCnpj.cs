using Newtonsoft.Json;

namespace Domain.Entities;

public sealed class DadosCnaeSecundarioCnpj : BaseEntity
{
    [JsonProperty("tipo_de_registro")]
    public string TipoRegistro { get; set; } = string.Empty;

    [JsonProperty("indicador")]
    public string Indicador { get; set; } = string.Empty;

    [JsonProperty("tipo_atualizacao")]
    public string TipoAtualizacao { get; set; } = string.Empty;

    [JsonProperty("cnpj")]
    public string Cnpj { get; set; } = string.Empty;

    [JsonProperty("cnae_secundario")]
    public string CnaeSecundario { get; set; } = string.Empty;

    [JsonProperty("filler")]
    public string Filler { get; set;} = string.Empty;
}
