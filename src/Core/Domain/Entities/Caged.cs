﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public sealed class Caged : BaseEntity
{
    [Column("Secao")]
    public string Secao { get; set; } = string.Empty;

    [Column("municipio")]
    public string Municipio { get; set;  } = string.Empty;

    [Column("uf")]
    public string UnidadeFederativa { get; set; } = string.Empty;

    [Column("faixa_empregados")]
    public string FaixaEmpregados { get; set; } = string.Empty;

    [Column("competencia")]
    public DateTime? Competencia { get; set; }

    [Column("fluxo")]
    public long Fluxo { get; set; }

    public long FaixaEmpregadosNumber => Convert.ToInt64(FaixaEmpregados);
}
