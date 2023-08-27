using Newtonsoft.Json;

namespace Domain.Entities;

public sealed class Cnae : BaseEntity
{
    [JsonProperty("cod_secao")]
    public string CodigoSecao { get; set; } = string.Empty;

    [JsonProperty("nm_secao")]
    public string NomeSecao { get; set; } = string.Empty;

    [JsonProperty("cod_divisao")]
    public string CodigoDivisao { get; set; } = string.Empty;

    [JsonProperty("nm_divisao")]
    public string NomeDivisao { get; set; } = string.Empty;

    [JsonProperty("cod_grupo")]
    public string CodigoGrupo { get; set; } = string.Empty;

    [JsonProperty("nm_grupo")]
    public string NomeGrupo { get; set; } = string.Empty;

    [JsonProperty("cod_classe")]
    public string CodigoClasse { get; set; } = string.Empty;

    [JsonProperty("nm_classe")]
    public string NomeClasse { get; set; } = string.Empty;

    [JsonProperty("cod_cnae")]
    public string CodigoCnae { get; set; } = string.Empty;

    [JsonProperty("nm_cnae")]
    public string NomeCnae { get; set; } = string.Empty;
}
