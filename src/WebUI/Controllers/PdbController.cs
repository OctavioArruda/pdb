using System.Collections.Immutable;
using System.Linq.Expressions;
using Domain.Contracts.Interfaces.Services;
using Domain.Entities;
using Domain.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace pdb.Controllers;

[ApiController]
[Route("[controller]")]
public class PdbController : ControllerBase
{
    private readonly IGenericService<Caged> _cagedService;
    private readonly IGenericService<DadosCadastraisCnpj> _dadosCadastraisCnpjService;
    private readonly IGenericService<DadosCnaeSecundarioCnpj> _dadosCnaeSecundarioService;
    private readonly IGenericService<DadosSocioCnpj> _dadosSociosCnpjService;
    private readonly IGenericService<Cnae> _cnaeService;

    public PdbController(IGenericService<Caged> cagedService,
        IGenericService<DadosCadastraisCnpj> dadosCadastraisCnpjService,
        IGenericService<DadosCnaeSecundarioCnpj> dadosCnaeSecundarioService,
        IGenericService<DadosSocioCnpj> dadosSociosCnpjService,
        IGenericService<Cnae> cnaeService)
    {
        _cagedService = cagedService;
        _dadosCadastraisCnpjService = dadosCadastraisCnpjService;
        _dadosCnaeSecundarioService = dadosCnaeSecundarioService;
        _dadosSociosCnpjService = dadosSociosCnpjService;
        _cnaeService = cnaeService;
    }

    [HttpGet("Caged", Name = "GetCaged")]
    public async Task<IEnumerable<Caged>> GetCaged([FromQuery]int pageNumber, int pageSize)
    {
        return await _cagedService.GetAsync(pageNumber, pageSize);
    }

    [HttpGet("DadosCadastraisCnpj", Name = "GetDadosCadastraisCnpj")]
    public async Task<IEnumerable<DadosCadastraisCnpj>> GetDadosCadastraisCnpj([FromQuery] int pageNumber, int pageSize)
    {
        return await _dadosCadastraisCnpjService.GetAsync(pageNumber, pageSize);
    }

    [HttpGet("DadosCnaeSecundarioCnpj", Name = "GetDadosCnaeSecundarioCnpj")]
    public async Task<IEnumerable<DadosCnaeSecundarioCnpj>> GetDadosCnaeSecundarioCnpj([FromQuery] int pageNumber, int pageSize)
    {
        return await _dadosCnaeSecundarioService.GetAsync(pageNumber, pageSize);
    }

    [HttpGet("DadosSociosCnpj", Name = "GetDadosSociosCnpj")]
    public async Task<IEnumerable<DadosSocioCnpj>> GetDadosSociosCnpj([FromQuery] int pageNumber, int pageSize)
    {
        return await _dadosSociosCnpjService.GetAsync(pageNumber, pageSize);
    }

    [HttpGet("DadosSociosCnae", Name = "GetDadosSociosCnae")]
    public async Task<IEnumerable<DadosCnaeSecundarioCadastraisCnpjDto>> GetDadosSociosCnae([FromQuery] int pageNumber, int pageSize)
    {
        var dadosSociosCnpj = await _dadosSociosCnpjService.GetAsync(pageNumber, pageSize);
        var dadosCnaeSecundario = await _dadosCnaeSecundarioService.GetAsync(pageNumber, pageSize);

        var uniqueSociosCnpj = dadosSociosCnpj.Select(cnpj => cnpj.Cnpj).Distinct();

        var dados = uniqueSociosCnpj
            .Where(cnpj => dadosCnaeSecundario.Any(cnae => cnae.Cnpj == cnpj))
            .Select(cnpj =>
            {
                var cnpjData = dadosSociosCnpj.First(data => data.Cnpj == cnpj);
                var cnaeData = dadosCnaeSecundario.First(data => data.Cnpj == cnpj);
                return new DadosCnaeSecundarioCadastraisCnpjDto(
                    cnpj, cnpjData.TipoRegistro, cnpjData.Indicador, 
                    cnpjData.TipoAtualizacao, cnaeData.CnaeSecundario, 
                    cnpjData.CpfRepresentanteLegal, cnpjData.CnpjCpfSocio);
            })
            .ToImmutableList();

        return dados;
    }

    [HttpGet("DadosMediaFaixaEmpregadosPorSecao", Name = "GetDadosMediaFaixaEmpregadosPorSecao")]
    public async Task<IEnumerable<DadosCagedPorSecaoDto>> GetDadosMediaFaixaEmpregadosPorSecao()
    {
        var dadosCaged = await _cagedService.GetAsync(x => x.Secao);
        var dadosCnae = await _cnaeService.GetAsync();
        var uniqueSecoes = dadosCnae.Select(cnae => cnae.CodigoSecao).Distinct();
        var dados = new List<DadosCagedPorSecaoDto>();
        var means = dadosCaged.Select(group =>
        {
            decimal sum = group.Sum(x => x.FaixaEmpregadosNumber);
            decimal mean = Math.Round(sum / group.Count(), 4);

            return new { group.Key, Mean = mean };
        });

        foreach (var cagedMean in means)
        { 
            var cnae = dadosCnae.FirstOrDefault(x => x.CodigoSecao == cagedMean.Key);
            var caged = dadosCaged.FirstOrDefault(x => x.Key == cagedMean.Key);
            dados.Add(new DadosCagedPorSecaoDto(cnae?.CodigoSecao, cnae?.NomeSecao,
                        cnae?.CodigoSecao, cnae?.NomeDivisao, cnae?.CodigoCnae,
                        cnae?.NomeCnae, caged?.FirstOrDefault()?.Municipio, caged?.FirstOrDefault()?.FaixaEmpregados,
                        caged?.FirstOrDefault()?.Competencia, cagedMean.Mean));
        }

        return dados;
    }
}
