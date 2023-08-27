using Newtonsoft.Json;

namespace Domain.Entities;

public sealed class DadosSocioCnpj : BaseEntity
{
    [JsonProperty("tipo_de_registro")]
    public string TipoRegistro { get; set; } = string.Empty;

    [JsonProperty("indicador")]
    public string Indicador { get; set;} = string.Empty;

    [JsonProperty("tipo_atualizacao")]
    public string TipoAtualizacao { get; set; } = string.Empty;

    [JsonProperty("cnpj")]
    public string Cnpj { get; set; } = string.Empty;

    [JsonProperty("identificador_socio")]
    public string IdentificadorSocio { get; set; } = string.Empty;

    [JsonProperty("nome_socio")]
    public string NomeSocio { get; set; } = string.Empty;

    [JsonProperty("cnpj_cpf_socio")]
    public string CnpjCpfSocio { get; set; } = string.Empty;

    [JsonProperty("cod_qualificacao_socio")]
    public string CodigoQualificacaoSocio { get; set; } = string.Empty;

    [JsonProperty("percentual_capital_socio")]
    public string PercentualCapitalSocio { get; set;} = string.Empty;

    [JsonProperty("data_entrada_sociedade")]
    public string DataEntradaSociedade { get; set; } = string.Empty;

    [JsonProperty("cod_pais")]
    public string CodigoPais { get; set;} = string.Empty;

    [JsonProperty("nome_pais_socio")]
    public string NomePaisSocio { get; set;} = string.Empty;

    [JsonProperty("cpf_representante_legal")]
    public string CpfRepresentanteLegal { get; set;} = string.Empty;

    [JsonProperty("nome_representante")]
    public string NomeRepresentante { get; set; } = string.Empty;

    [JsonProperty("cod_qualificacao_representante_legal")]
    public string CodigoQualificacaoRepresentanteLegal { get; set;} = string.Empty;

    [JsonProperty("fim_registro")]
    public string FimRegistro { get; set; } = string.Empty;
}
