namespace RealEstateAd_CleanArchitecture.Domain.Entities.OpenMeteo;

using Newtonsoft.Json;

public class ErrorMsg
{
    [JsonProperty("error")]
    public bool Error { get; set; }

    [JsonProperty("reason")]
    public string Reason { get; set; }
}
