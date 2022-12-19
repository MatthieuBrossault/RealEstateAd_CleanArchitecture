using RealEstateAd_CleanArchitecture.Application.Common.Exceptions;
using FluentAssertions;
using NUnit.Framework;
using RealEstateAd_CleanArchitecture.Application.RealEstate.Commands.UpdateRealEstateAd;
using RealEstateAd_CleanArchitecture.Application.RealEstate.Commands.CreateRealEstateAd;
using RealEstateAd_CleanArchitecture.Domain.ValueObjects;
using RealEstateAd_CleanArchitecture.Domain.Enums;
using RealEstateAd_CleanArchitecture.Domain.Entities.RealEstate;

namespace RealEstateAd_CleanArchitecture.Application.IntegrationTests.RealEstate.Commands;

using static Testing;

public class UpdateRealEstateAdTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidRealEstateAdId()
    {
        var command = new UpdateRealEstateAdCommand { Id = 99, PublicationStatus = (int)PublicationStatus.Published };
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldUpdateRealEstateAd()
    {
        var userId = await RunAsDefaultUserAsync();

        var itemId = await SendAsync(new CreateRealEstateAdCommand
        {
            Title = "T2 Apt Nantes",
            Description = "A T2 type appartement at Nantes",
            Location = new Location(47.218637, -1.554136, "13 Boulevard Emile Romanet", "Nantes", string.Empty, "France", "44100"),
            PropertyType = PropertyType.Apartment
        });

        var command = new UpdateRealEstateAdCommand
        {
            Id = itemId,
            PublicationStatus = (int)PublicationStatus.Published
        };

        await SendAsync(command);

        var item = await FindAsync<RealEstateAd>(itemId);

        item.Should().NotBeNull();
        item!.PublicationStatus.Should().Be((PublicationStatus)command.PublicationStatus);
        item.LastModifiedBy.Should().NotBeNull();
        item.LastModifiedBy.Should().Be(userId);
        item.LastModified.Should().NotBeNull();
        item.LastModified.Should().BeCloseTo(DateTime.Now, TimeSpan.FromMilliseconds(10000));
    }
}
