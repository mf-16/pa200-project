using BusinessLayer.DTOs.Publisher;
using BusinessLayer.Exceptions;
using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PublishersController : ControllerBase
{
    private readonly IPublisherService _publisherService;

    public PublishersController(IPublisherService publisherService)
    {
        _publisherService = publisherService;
    }

    [HttpGet]
    public async Task<ActionResult> GetAllPublishers()
    {
        var publishers = await _publisherService.GetAllPublishersAsync();
        return Ok(publishers);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetPublisherById(int id)
    {
        var publisher = await _publisherService.GetPublisherByIdAsync(id);
        if (publisher == null)
            return NotFound();
        return Ok(publisher);
    }

    [HttpPost]
    public async Task<ActionResult> AddPublisher([FromBody] AddPublisherDto addPublisherDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var publisher = await _publisherService.AddPublisherAsync(addPublisherDto);
        return CreatedAtAction(nameof(GetPublisherById), new { id = publisher.Id }, publisher);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdatePublisher(int id, [FromBody] AddPublisherDto updatePublisherDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var publisher = await _publisherService.UpdatePublisherAsync(id, updatePublisherDto);
        if (publisher == null) return NotFound();
        return Ok(publisher);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ResponsePublisherDto>> DeletePublisher(int id)
    {
        await _publisherService.DeletePublisherAsync(id);
        return Ok(new { message = "Publisher successfully deleted" });
    }
}
