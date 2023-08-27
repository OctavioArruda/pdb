using Newtonsoft.Json;

namespace Domain.Entities;

public sealed class NaturezaJuridica : BaseEntity
{
    [JsonProperty("cod_natureza_juridica")]
    public string Codigo { get; set; } = string.Empty;

    [JsonProperty("nm_natureza_juridica")]
    public string Nome { get; set; } = string.Empty;

    [JsonProperty("cod_subclass_natureza_juridica")]
    public string CodigoSubclasse { get; set; } = string.Empty;

    [JsonProperty("nm_subclass_natureza_juridica")]
    public string NomeSubclasse { get; set; } = string.Empty;
}
