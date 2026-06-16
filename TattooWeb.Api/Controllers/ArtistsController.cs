using Microsoft.AspNetCore.Mvc;
using TattooWeb.Application.UseCases.Artists.CreateArtist;
using TattooWeb.Application.UseCases.Artists.DeleteArtist;
using TattooWeb.Application.UseCases.Artists.GetAllArtists;
using TattooWeb.Application.UseCases.Artists.GetArtistById;
using TattooWeb.Application.UseCases.Artists.UpdateArtist;

namespace TattooWeb.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArtistsController(
    CreateArtistUseCase createArtist,
    GetAllArtistsUseCase getAllArtists,
    GetArtistByIdUseCase getArtistById,
    UpdateArtistUseCase updateArtist,
    DeleteArtistUseCase deleteArtist) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateArtistCommand command)
    {
        var artist = await createArtist.ExecuteAsync(command);
        return CreatedAtAction(nameof(GetById), new { id = artist.Id }, artist);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var artists = await getAllArtists.ExecuteAsync();
        return Ok(artists);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var artist = await getArtistById.ExecuteAsync(id);
        if (artist is null) return NotFound();
        return Ok(artist);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateArtistCommand command)
    {
        if (id != command.Id) return BadRequest();
        var artist = await updateArtist.ExecuteAsync(command);
        if (artist is null) return NotFound();
        return Ok(artist);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await deleteArtist.ExecuteAsync(id);
        return NoContent();
    }
}
