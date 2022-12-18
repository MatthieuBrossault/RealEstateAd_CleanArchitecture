using RealEstateAd_CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RealEstateAd_CleanArchitecture.Domain.Entities.RealEstate;

namespace RealEstateAd_CleanArchitecture.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<RealEstateAd> RealEstateAds { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
