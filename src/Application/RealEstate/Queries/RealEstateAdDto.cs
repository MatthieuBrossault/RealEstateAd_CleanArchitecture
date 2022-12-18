using RealEstateAd_CleanArchitecture.Application.Common.Mappings;
using RealEstateAd_CleanArchitecture.Domain.Entities.RealEstate;

namespace RealEstateAd_CleanArchitecture.Application.RealEstate.Queries;

public class RealEstateAdDto : IMapFrom<RealEstateAd>
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string? Description { get; set; }
}
