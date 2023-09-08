using Domain.Contracts.Interfaces.Repositories;
using Domain.Contracts.Interfaces.Services;
using Domain.Entities;
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

    public PdbController(IGenericService<Caged> cagedService, 
        IGenericService<DadosCadastraisCnpj> dadosCadastraisCnpjService, 
        IGenericService<DadosCnaeSecundarioCnpj> dadosCnaeSecundarioService,
        IGenericService<DadosSocioCnpj> dadosSociosCnpjService)
    {
        _cagedService = cagedService;
        _dadosCadastraisCnpjService = dadosCadastraisCnpjService;
        _dadosCnaeSecundarioService = dadosCnaeSecundarioService;
        _dadosSociosCnpjService = dadosSociosCnpjService;
    }

    [HttpGet("Caged", Name = "GetCaged")]
    public async Task<IEnumerable<Caged>> GetCaged([FromQuery]int pageNumber, int pageSize)
    {
        return await _cagedService.Get(pageNumber, pageSize);
    }

    [HttpGet("DadosCadastraisCnpj", Name = "GetDadosCadastraisCnpj")]
    public async Task<IEnumerable<DadosCadastraisCnpj>> GetDadosCadastraisCnpj([FromQuery] int pageNumber, int pageSize)
    {
        return await _dadosCadastraisCnpjService.Get(pageNumber, pageSize);
    }

    [HttpGet("DadosCnaeSecundarioCnpj", Name = "GetDadosCnaeSecundarioCnpj")]
    public async Task<IEnumerable<DadosCnaeSecundarioCnpj>> GetDadosCnaeSecundarioCnpj([FromQuery] int pageNumber, int pageSize)
    {
        return await _dadosCnaeSecundarioService.Get(pageNumber, pageSize);
    }

    [HttpGet("DadosSociosCnpj", Name = "GetDadosSociosCnpj")]
    public async Task<IEnumerable<DadosSocioCnpj>> GetDadosSociosCnpj([FromQuery] int pageNumber, int pageSize)
    {
        return await _dadosSociosCnpjService.Get(pageNumber, pageSize);
    }
}
