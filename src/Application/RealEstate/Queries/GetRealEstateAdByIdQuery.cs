using AutoMapper;
using AutoMapper.QueryableExtensions;
using RealEstateAd_CleanArchitecture.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace RealEstateAd_CleanArchitecture.Application.RealEstate.Queries.GetRealEstateAdById;

public record GetRealEstateAdByIdQuery : IRequest<RealEstateAdDto>
{
    public int Id { get; init; }
}

public class GetRealEstateAdByIdQueryHandler : IRequestHandler<GetRealEstateAdByIdQuery, RealEstateAdDto>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetRealEstateAdByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<RealEstateAdDto> Handle(GetRealEstateAdByIdQuery request, CancellationToken cancellationToken)
    {
        return await _context.RealEstateAds
            .Where(x => x.Id == request.Id)
            .ProjectTo<RealEstateAdDto>(_mapper.ConfigurationProvider)
            .SingleAsync();
    }
}
