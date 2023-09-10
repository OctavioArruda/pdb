using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("cnpj_dados_cnae_secundario_pj")]
public sealed class DadosCnaeSecundarioCnpj : BaseEntity
{
    [Column("tipo_de_registro")]
    public string TipoRegistro { get; set; } = string.Empty;

    [Column("indicador")]
    public string Indicador { get; set; } = string.Empty;

    [Column("tipo_atualizacao")]
    public string TipoAtualizacao { get; set; } = string.Empty;

    [Column("cnpj")]
    public string Cnpj { get; set; } = string.Empty;

    [Column("cnae_secundario")]
    public string CnaeSecundario { get; set; } = string.Empty;

    [Column("filler")]
    public string Filler { get; set;} = string.Empty;
}
