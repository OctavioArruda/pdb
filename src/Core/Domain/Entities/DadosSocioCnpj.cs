using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("cnpj_dados_socios")]
public sealed class DadosSocioCnpj : BaseEntity
{
    [Column("tipo_de_registro")]
    public string TipoRegistro { get; set; } = string.Empty;

    [Column("indicador")]
    public string Indicador { get; set;} = string.Empty;

    [Column("tipo_atualizacao")]
    public string TipoAtualizacao { get; set; } = string.Empty;

    [Column("cnpj")]
    public string Cnpj { get; set; } = string.Empty;

    [Column("identificador_socio")]
    public string IdentificadorSocio { get; set; } = string.Empty;

    [Column("nome_socio")]
    public string NomeSocio { get; set; } = string.Empty;

    [Column("cnpj_cpf_socio")]
    public string CnpjCpfSocio { get; set; } = string.Empty;

    [Column("cod_qualificacao_socio")]
    public string CodigoQualificacaoSocio { get; set; } = string.Empty;

    [Column("percentual_capital_socio")]
    public string PercentualCapitalSocio { get; set;} = string.Empty;

    [Column("data_entrada_sociedade")]
    public string DataEntradaSociedade { get; set; } = string.Empty;

    [Column("cod_pais")]
    public string CodigoPais { get; set;} = string.Empty;

    [Column("nome_pais_socio")]
    public string NomePaisSocio { get; set;} = string.Empty;

    [Column("cpf_representante_legal")]
    public string CpfRepresentanteLegal { get; set;} = string.Empty;

    [Column("nome_representante")]
    public string NomeRepresentante { get; set; } = string.Empty;

    [Column("cod_qualificacao_representante_legal")]
    public string CodigoQualificacaoRepresentanteLegal { get; set;} = string.Empty;

    [Column("fim_registro")]
    public string FimRegistro { get; set; } = string.Empty;
}
