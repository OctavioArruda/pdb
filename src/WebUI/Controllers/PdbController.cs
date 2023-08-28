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

    public PdbController(IGenericService<Caged> cagedService, IGenericService<DadosCadastraisCnpj> dadosCadastraisCnpjService)
    {
        _cagedService = cagedService;
        _dadosCadastraisCnpjService = dadosCadastraisCnpjService;
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
}
