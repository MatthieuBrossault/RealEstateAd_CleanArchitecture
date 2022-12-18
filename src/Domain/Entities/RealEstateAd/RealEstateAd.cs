namespace RealEstateAd_CleanArchitecture.Domain.Entities.RealEstateAd;

public class RealEstateAd
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Location Location { get; set; } = new Location();
    public PropertyType PropertyType { get; set; }
    public PublicationStatus PublicationStatus { get; set; }
}
