namespace Domain.Entities.Dtos;

public record DadosCagedPorSecaoDto (
    string? CodigoSecao,
    string? NomeSecao,
    string? CodigoDivisao,
    string? NomeDivisa,
    string? CodigoCnae,
    string? NomeCnae,
    string? Municipio,
    string? FaixaEmpregados,
    DateTime? Competencia,
    decimal MediaFaixaEmpregadosPorSecao);