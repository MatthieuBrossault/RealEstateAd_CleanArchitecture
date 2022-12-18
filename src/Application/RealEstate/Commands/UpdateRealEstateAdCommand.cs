using RealEstateAd_CleanArchitecture.Application.Common.Exceptions;
using RealEstateAd_CleanArchitecture.Application.Common.Interfaces;
using RealEstateAd_CleanArchitecture.Domain.Entities.RealEstate;
using RealEstateAd_CleanArchitecture.Domain.Enums;
using MediatR;

namespace RealEstateAd_CleanArchitecture.Application.RealEstate.Commands.UpdateRealEstateAd;

public record UpdateRealEstateAdCommand : IRequest
{
    public int Id { get; init; }

    public int PublicationStatus { get; init; }
}

public class UpdateRealEstateAdCommandHandler : IRequestHandler<UpdateRealEstateAdCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateRealEstateAdCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(UpdateRealEstateAdCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.RealEstateAds
            .FindAsync(new object[] { request.Id }, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(RealEstateAd), request.Id);
        }

        entity.PublicationStatus = (PublicationStatus)request.PublicationStatus;

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
