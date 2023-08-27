using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public sealed class Cnae : BaseEntity
{
    [Column("cod_secao")]
    public string CodigoSecao { get; set; } = string.Empty;

    [Column("nm_secao")]
    public string NomeSecao { get; set; } = string.Empty;

    [Column("cod_divisao")]
    public string CodigoDivisao { get; set; } = string.Empty;

    [Column("nm_divisao")]
    public string NomeDivisao { get; set; } = string.Empty;

    [Column("cod_grupo")]
    public string CodigoGrupo { get; set; } = string.Empty;

    [Column("nm_grupo")]
    public string NomeGrupo { get; set; } = string.Empty;

    [Column("cod_classe")]
    public string CodigoClasse { get; set; } = string.Empty;

    [Column("nm_classe")]
    public string NomeClasse { get; set; } = string.Empty;

    [Column("cod_cnae")]
    public string CodigoCnae { get; set; } = string.Empty;

    [Column("nm_cnae")]
    public string NomeCnae { get; set; } = string.Empty;
}
