using Newtonsoft.Json;

namespace Domain.Entities;

public sealed class DadosCadastraisCnpj : BaseEntity
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

    [JsonProperty("situacao_cadastral")]
    public string SituacaoCadastral { get; set; } = string.Empty;

    [JsonProperty("data_situacao_cadastral")]
    public string DataSituacaoCadastral { get; set; } = string.Empty;

    [JsonProperty("motivo_situacao_cadastral")]
    public string MotivoSituacaoCadastral { get; set; } = string.Empty;

    [JsonProperty("nm_cidade_exterior")]
    public string NomeCidadeExterior { get; set; } = string.Empty;

    [JsonProperty("cod_pais")]
    public string CodigoPais { get;set; } = string.Empty;

    [JsonProperty("nm_pais")]
    public string NomePais { get; set; } = string.Empty;

    [JsonProperty("codigo_natureza_juridica")]
    public string CodigoNaturezaJuridica { get; set; } = string.Empty;

    [JsonProperty("data_inicio_atividade")]
    public string DataInicioAtividade { get; set; } = string.Empty;

    [JsonProperty("cnae_fiscal")]
    public string CnaeFiscal { get; set; } = string.Empty;

    [JsonProperty("descricao_tipo_logradouro")]
    public string DescricaoTipoLogradouro { get; set; } = string.Empty;

    [JsonProperty("logradouro")]
    public string Logradouro { get; set; } = string.Empty;

    [JsonProperty("numero")]
    public string Numero { get; set;} = string.Empty;

    [JsonProperty("complemento")]
    public string Complemento { get; set;} = string.Empty;

    [JsonProperty("bairro")]
    public string Bairro { get; set; } = string.Empty;

    [JsonProperty("cep")]
    public string Cep { get; set;} = string.Empty;

    [JsonProperty("uf")]
    public string UnidadeFederativa { get; set; } = string.Empty;

    [JsonProperty("codigo_municipio")]
    public string CodigoMunicipio { get; set; } = string.Empty;

    [JsonProperty("municipio")]
    public string Municipio { get; set; } = string.Empty;

    [JsonProperty("ddd_telefone_1")]
    public string DddTelefonePrimario { get; set; } = string.Empty;

    [JsonProperty("ddd_telefone_2")]
    public string DddTelefoneSecundario { get; set; } = string.Empty;

    [JsonProperty("ddd_fax")]
    public string DddFax { get; set; } = string.Empty;

    [JsonProperty("correio_eletronico")]
    public string CorreioEletronico { get; set; } = string.Empty;

    [JsonProperty("qualificacao_responsavel")]
    public string QualificacaoResponsavel { get; set; } = string.Empty;

    [JsonProperty("capital_social_empresa")]
    public decimal CapitalSocialEmpresa { get; set; }

    [JsonProperty("porte_empresa")]
    public string PorteEmpresa { get; set; } = string.Empty;

    [JsonProperty("opcao_pelo_simples")]
    public string OpcaoPeloSimples { get; set; } = string.Empty;

    [JsonProperty("data_opcao_pelo_simples")]
    public string DataOpcaoPeloSimples { get; set; } = string.Empty;

    [JsonProperty("data_exclusao_simples")]
    public string DataExclusaoSimples { get; set; } = string.Empty;

    [JsonProperty("opcao_pelo_mei")]
    public string OpcaoPeloMei { get; set; } = string.Empty;

    [JsonProperty("situacao_especial")]
    public string SituacaoEspecial { get; set; } = string.Empty;

    [JsonProperty("data_situacao_especial")]
    public string DataSituacaoEspecial { get; set; } = string.Empty;

    [JsonProperty("filler")]
    public string Filler { get; set; } = string.Empty;

    [JsonProperty("fim_registro")]
    public string FimRegistro { get; set; } = string.Empty;
}
