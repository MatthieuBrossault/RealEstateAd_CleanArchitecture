using RealEstateAd_CleanArchitecture.Application.Common.Mappings;
using RealEstateAd_CleanArchitecture.Domain.Entities;
using RealEstateAd_CleanArchitecture.Domain.Entities.RealEstate;

namespace RealEstateAd_CleanArchitecture.Application.Common.Models;

// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>, IMapFrom<RealEstateAd>
{
    public int Id { get; set; }

    public string? Title { get; set; }
}
