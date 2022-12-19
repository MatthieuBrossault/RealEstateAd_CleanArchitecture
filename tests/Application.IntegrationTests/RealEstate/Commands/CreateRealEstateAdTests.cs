using RealEstateAd_CleanArchitecture.Application.Common.Exceptions;
using RealEstateAd_CleanArchitecture.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;
using RealEstateAd_CleanArchitecture.Application.RealEstate.Commands.CreateRealEstateAd;
using RealEstateAd_CleanArchitecture.Domain.ValueObjects;
using RealEstateAd_CleanArchitecture.Domain.Entities.RealEstate;

namespace RealEstateAd_CleanArchitecture.Application.IntegrationTests.RealEstate.Commands;

using static Testing;

public class CreateRealEstateAdTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireMinimumFields()
    {
        var command = new CreateRealEstateAdCommand();

        await FluentActions.Invoking(() =>
            SendAsync(command)).Should().ThrowAsync<ValidationException>();
    }

    [Test]
    public async Task ShouldCreateRealEstateAd()
    {
        var userId = await RunAsDefaultUserAsync();

        var command = new CreateRealEstateAdCommand
        {
            Title = "T2 Apt Nantes",
            Description = "A T2 type appartement at Nantes",
            Location = new Location(47.218637, -1.554136, "13 Boulevard Emile Romanet", "Nantes", string.Empty, "France", "44100"),
            PropertyType = Domain.Enums.PropertyType.Apartment
        };

        var itemId = await SendAsync(command);

        var item = await FindAsync<RealEstateAd>(itemId);

        item.Should().NotBeNull();
        item.Title.Should().Be(command.Title);
        item.Description.Should().Be(command.Description);
        item.Location.Should().Be(command.Location);
        item.PropertyType.Should().Be(command.PropertyType);
        item.CreatedBy.Should().Be(userId);
        item.Created.Should().BeCloseTo(DateTime.Now, TimeSpan.FromMilliseconds(10000));
        item.LastModifiedBy.Should().Be(userId);
        item.LastModified.Should().BeCloseTo(DateTime.Now, TimeSpan.FromMilliseconds(10000));
    }
}
