using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateAd_CleanArchitecture.Domain.Entities.RealEstate;

namespace RealEstateAd_CleanArchitecture.Infrastructure.Persistence.Configurations;

public class RealEstateAdConfiguration : IEntityTypeConfiguration<RealEstateAd>
{
    public void Configure(EntityTypeBuilder<RealEstateAd> builder)
    {
        builder.Property(t => t.Title)
            .HasMaxLength(200)
            .IsRequired();

        builder
            .OwnsOne(b => b.Location);
    }
}
