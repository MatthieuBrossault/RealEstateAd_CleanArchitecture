using RealEstateAd_CleanArchitecture.Application.Common.Interfaces;

namespace RealEstateAd_CleanArchitecture.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
