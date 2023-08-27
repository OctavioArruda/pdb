using Newtonsoft.Json;

namespace Domain.Entities;

public sealed class DadosCnpj : BaseEntity
{
    [JsonProperty("tipo_de_registro")]
    public string TipoRegistro { get; set; } = string.Empty;

    [JsonProperty("indicador")]
    public string Indicador { get; set; } = string.Empty;

    [JsonProperty("tipo_atualizacao")]
    public string TipoAtualizacao { get; set; } = string.Empty;

    [JsonProperty("cnpj")]
    public string Cnpj { get; set; } = string.Empty;

    [JsonProperty("identificador_matriz_filial")]
    public string IdentificadorMatrizFilial { get; set; } = string.Empty;

    [JsonProperty("razao_social")]
    public string RazaoSocial { get; set; } = string.Empty;

    [JsonProperty("nome_fantasia")]
    public string NomeFantasia { get; set; } = string.Empty;
}
