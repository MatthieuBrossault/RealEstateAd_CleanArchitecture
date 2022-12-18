namespace RealEstateAd_CleanArchitecture.Domain.Entities.OpenMeteo;

using Newtonsoft.Json;

public class HourlyUnits
{
    [JsonProperty("temperature_2m")]
    public string Temperature2M { get; set; }
}
