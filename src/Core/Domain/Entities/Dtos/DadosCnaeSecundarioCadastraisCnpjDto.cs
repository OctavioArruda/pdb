namespace Domain.Entities.Dtos;

public record DadosCnaeSecundarioCadastraisCnpjDto(
    string Cnpj,
    string TipoRegistro,
    string Indicador,
    string TipoAtualizacao,
    string CnaeSecundario,
    string CpfRepresentanteLegal,
    string CnpjCpfSocio);