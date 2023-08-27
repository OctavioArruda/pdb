using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public sealed class NaturezaJuridica : BaseEntity
{
    [Column("cod_natureza_juridica")]
    public string Codigo { get; set; } = string.Empty;

    [Column("nm_natureza_juridica")]
    public string Nome { get; set; } = string.Empty;

    [Column("cod_subclass_natureza_juridica")]
    public string CodigoSubclasse { get; set; } = string.Empty;

    [Column("nm_subclass_natureza_juridica")]
    public string NomeSubclasse { get; set; } = string.Empty;
}
