namespace RealEstateAd_CleanArchitecture.Domain.Entities.RealEstate;

public class RealEstateAd : BaseAuditableEntity
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Location Location { get; set; }
    public PropertyType PropertyType { get; set; }
    public PublicationStatus PublicationStatus { get; set; }
}
