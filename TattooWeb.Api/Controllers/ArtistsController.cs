using Microsoft.AspNetCore.Mvc;
using TattooWeb.Application.UseCases.Artists.CreateArtist;

namespace TattooWeb.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArtistsController(CreateArtistUseCase createArtist) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateArtistCommand command)
    {
        var artist = await createArtist.ExecuteAsync(command);
        return CreatedAtAction(nameof(Create), new { id = artist.Id }, artist);
    }
}