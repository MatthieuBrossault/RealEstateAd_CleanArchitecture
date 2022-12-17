using RealEstateAd_CleanArchitecture.Application.Common.Mappings;
using RealEstateAd_CleanArchitecture.Domain.Entities;

namespace RealEstateAd_CleanArchitecture.Application.Common.Models;

// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public string? Title { get; set; }
}
