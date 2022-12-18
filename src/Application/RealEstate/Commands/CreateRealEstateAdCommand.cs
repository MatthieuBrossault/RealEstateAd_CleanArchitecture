using RealEstateAd_CleanArchitecture.Application.Common.Interfaces;
using RealEstateAd_CleanArchitecture.Domain.Entities.RealEstate;
using MediatR;
using RealEstateAd_CleanArchitecture.Domain.ValueObjects;
using RealEstateAd_CleanArchitecture.Domain.Enums;

namespace RealEstateAd_CleanArchitecture.Application.RealEstate.Commands.CreateRealEstateAd;

public record CreateRealEstateAdCommand : IRequest<int>
{
    public string Title { get; init; }

    public string? Description { get; set; }

    public Location Location { get; set; }

    public PropertyType PropertyType { get; set; }
}

public class CreateRealEstateAdCommandHandler : IRequestHandler<CreateRealEstateAdCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateRealEstateAdCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateRealEstateAdCommand request, CancellationToken cancellationToken)
    {
        var entity = new RealEstateAd
        {
            Title = request.Title,
            Description = request.Description,
            Location = request.Location,
            PropertyType = request.PropertyType,
            PublicationStatus = PublicationStatus.WaitingValidation
        };

        _context.RealEstateAds.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
