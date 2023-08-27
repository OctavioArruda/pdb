using Newtonsoft.Json;

namespace Domain.Entities;

public class Caged //: BaseEntity
{
    [JsonProperty("cd_municipio")]
    public string CodigoMunicipio { get; set; } = string.Empty;

    [JsonProperty("municipio")]
    public string Municipio { get; set;  } = string.Empty;

    [JsonProperty("uf")]
    public string UnidadeFederativa { get; set; } = string.Empty;

    [JsonProperty("faixa_empregados")]
    public string FaixaEmpregados { get; set; } = string.Empty;

    [JsonProperty("competencia")]
    public DateTime? Competencia { get; set; }

    [JsonProperty("fluxo")]
    public long Fluxo { get; set; }
}
