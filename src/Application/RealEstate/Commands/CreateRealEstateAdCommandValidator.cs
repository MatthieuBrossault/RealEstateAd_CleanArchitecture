using FluentValidation;

namespace RealEstateAd_CleanArchitecture.Application.RealEstate.Commands.CreateRealEstateAd;

public class CreateRealEstateAdCommandValidator : AbstractValidator<CreateRealEstateAdCommand>
{
    public CreateRealEstateAdCommandValidator()
    {
        RuleFor(v => v.Title)
            .MaximumLength(200)
            .NotEmpty();

        RuleFor(v => v.PropertyType)
            .NotNull();

        RuleFor(v => v.Location)
            .NotNull();
    }
}
