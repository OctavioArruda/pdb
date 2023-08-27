using Domain.Contracts.Interfaces.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace pdb.Controllers;

[ApiController]
[Route("[controller]")]
public class PdbController : ControllerBase
{
    private readonly ICagedService _cagedService;

    public PdbController(ICagedService cagedService)
    {
        _cagedService = cagedService;
    }

    [HttpGet(Name = "Caged")]
    public async Task<IEnumerable<Caged>> Get()
    {
        return await _cagedService.Get();
    }
}
