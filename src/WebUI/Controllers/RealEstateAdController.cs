using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateAd_CleanArchitecture.Application.RealEstate.Queries;
using RealEstateAd_CleanArchitecture.Application.RealEstate.Queries.GetRealEstateAdById;
using RealEstateAd_CleanArchitecture.Application.RealEstate.Commands.CreateRealEstateAd;
using RealEstateAd_CleanArchitecture.Application.RealEstate.Commands.UpdateRealEstateAd;

namespace RealEstateAd_CleanArchitecture.WebUI.Controllers;

[Authorize]
public class RealEstateAdController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<RealEstateAdDto>> GetRealEstateAdById([FromQuery] GetRealEstateAdByIdQuery query)
    {
        return await Mediator.Send(query);
    }

    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateRealEstateAdCommand command)
    {
        return await Mediator.Send(command);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, UpdateRealEstateAdCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        await Mediator.Send(command);

        return NoContent();
    }
}
