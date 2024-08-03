using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class DestinationController : ControllerBase
{
    private readonly DestinationService _service;
    private readonly ILogger<DestinationController> _logger;

    public DestinationController(DestinationService service, ILogger<DestinationController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<List<Destination>>> Get() => await _service.GetAllAsync();

    [HttpGet("{id}")]
    public async Task<ActionResult<Destination?>> Get(int id) => await _service.GetByIdAsync(id);

    [HttpPost]
    public async Task<ActionResult> Post(Destination destination) { await _service.AddAsync(destination); return Ok(); }

    [HttpPut]
    public async Task<ActionResult> Put(Destination destination) { await _service.UpdateAsync(destination); return Ok(); }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id) { await _service.DeleteAsync(id); return Ok(); }

    [HttpGet("verify")]
    public async Task<IActionResult> VerifyDbConnection()
    {
       var destinations = await _service.GetAllAsync();
        
        // Log the data to the debug console
        foreach (var destination in destinations)
        {
            _logger.LogInformation($"ID: {destination.DestinationId}, Name: {destination.Name}, Description: {destination.Description}");
        }

        return new JsonResult(destinations);
    }
}