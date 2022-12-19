using FluentValidation;
using RealEstateAd_CleanArchitecture.Domain.Enums;

namespace RealEstateAd_CleanArchitecture.Application.RealEstate.Commands.UpdateRealEstateAd;

public class UpdateRealEstateAdCommandValidator : AbstractValidator<UpdateRealEstateAdCommand>
{
    public UpdateRealEstateAdCommandValidator()
    {
        RuleFor(v => v.PublicationStatus)
            .InclusiveBetween((int)PublicationStatus.WaitingValidation, (int)PublicationStatus.Published);
    }
}
