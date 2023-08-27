using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public sealed class DadosCadastraisCnpj : BaseEntity
{
    [Column("tipo_de_registro")]
    public string TipoRegistro { get; set; } = string.Empty;

    [Column("indicador")]
    public string Indicador { get; set; } = string.Empty;

    [Column("tipo_atualizacao")]
    public string TipoAtualizacao { get; set; } = string.Empty;

    [Column("cnpj")]
    public string Cnpj { get; set; } = string.Empty;

    [Column("identificador_matriz_filial")]
    public string IdentificadorMatrizFilial { get; set; } = string.Empty;

    [Column("razao_social")]
    public string RazaoSocial { get; set; } = string.Empty;

    [Column("nome_fantasia")]
    public string NomeFantasia { get; set; } = string.Empty;

    [Column("situacao_cadastral")]
    public string SituacaoCadastral { get; set; } = string.Empty;

    [Column("data_situacao_cadastral")]
    public string DataSituacaoCadastral { get; set; } = string.Empty;

    [Column("motivo_situacao_cadastral")]
    public string MotivoSituacaoCadastral { get; set; } = string.Empty;

    [Column("nm_cidade_exterior")]
    public string NomeCidadeExterior { get; set; } = string.Empty;

    [Column("cod_pais")]
    public string CodigoPais { get;set; } = string.Empty;

    [Column("nm_pais")]
    public string NomePais { get; set; } = string.Empty;

    [Column("codigo_natureza_juridica")]
    public string CodigoNaturezaJuridica { get; set; } = string.Empty;

    [Column("data_inicio_atividade")]
    public string DataInicioAtividade { get; set; } = string.Empty;

    [Column("cnae_fiscal")]
    public string CnaeFiscal { get; set; } = string.Empty;

    [Column("descricao_tipo_logradouro")]
    public string DescricaoTipoLogradouro { get; set; } = string.Empty;

    [Column("logradouro")]
    public string Logradouro { get; set; } = string.Empty;

    [Column("numero")]
    public string Numero { get; set;} = string.Empty;

    [Column("complemento")]
    public string Complemento { get; set;} = string.Empty;

    [Column("bairro")]
    public string Bairro { get; set; } = string.Empty;

    [Column("cep")]
    public string Cep { get; set;} = string.Empty;

    [Column("uf")]
    public string UnidadeFederativa { get; set; } = string.Empty;

    [Column("codigo_municipio")]
    public string CodigoMunicipio { get; set; } = string.Empty;

    [Column("municipio")]
    public string Municipio { get; set; } = string.Empty;

    [Column("ddd_telefone_1")]
    public string DddTelefonePrimario { get; set; } = string.Empty;

    [Column("ddd_telefone_2")]
    public string DddTelefoneSecundario { get; set; } = string.Empty;

    [Column("ddd_fax")]
    public string DddFax { get; set; } = string.Empty;

    [Column("correio_eletronico")]
    public string CorreioEletronico { get; set; } = string.Empty;

    [Column("qualificacao_responsavel")]
    public string QualificacaoResponsavel { get; set; } = string.Empty;

    [Column("capital_social_empresa")]
    public decimal CapitalSocialEmpresa { get; set; }

    [Column("porte_empresa")]
    public string PorteEmpresa { get; set; } = string.Empty;

    [Column("opcao_pelo_simples")]
    public string OpcaoPeloSimples { get; set; } = string.Empty;

    [Column("data_opcao_pelo_simples")]
    public string DataOpcaoPeloSimples { get; set; } = string.Empty;

    [Column("data_exclusao_simples")]
    public string DataExclusaoSimples { get; set; } = string.Empty;

    [Column("opcao_pelo_mei")]
    public string OpcaoPeloMei { get; set; } = string.Empty;

    [Column("situacao_especial")]
    public string SituacaoEspecial { get; set; } = string.Empty;

    [Column("data_situacao_especial")]
    public string DataSituacaoEspecial { get; set; } = string.Empty;

    [Column("filler")]
    public string Filler { get; set; } = string.Empty;

    [Column("fim_registro")]
    public string FimRegistro { get; set; } = string.Empty;
}
