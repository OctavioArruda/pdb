using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public sealed class CodigoMunicipioSiaf : BaseEntity
{
    [Column("codigo_siafi")]
    public string CodigoSiafi { get; set; } = string.Empty;

    [Column("cnpj")]
    public string Cnpj { get; set; } = string.Empty;

    [Column("descricao")]
    public string Descricao { get; set; } = string.Empty;

    [Column("uf")]
    public string UnidadeFederativa { get; set; } = string.Empty;

    [Column("codigo_ibge")]
    public string CodigoIbge { get; set; } = string.Empty;
}
