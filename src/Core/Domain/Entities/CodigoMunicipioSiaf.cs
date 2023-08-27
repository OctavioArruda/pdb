using Newtonsoft.Json;

namespace Domain.Entities;

public sealed class CodigoMunicipioSiaf : BaseEntity
{
    [JsonProperty("codigo_siafi")]
    public string CodigoSiafi { get; set; } = string.Empty;

    [JsonProperty("cnpj")]
    public string Cnpj { get; set; } = string.Empty;

    [JsonProperty("descricao")]
    public string Descricao { get; set; } = string.Empty;

    [JsonProperty("uf")]
    public string UnidadeFederativa { get; set; } = string.Empty;

    [JsonProperty("codigo_ibge")]
    public string CodigoIbge { get; set; } = string.Empty;
}
