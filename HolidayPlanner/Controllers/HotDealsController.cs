using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class HotDealsController : ControllerBase
{
    private readonly HotDealsService _service;
    private readonly ILogger<HotDealsController> _logger;

    public HotDealsController(HotDealsService service, ILogger<HotDealsController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<List<HotDeals>>> Get(){
        return await _service.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<HotDeals?>> Get(string id){
        return await _service.GetByIdAsync(id);
    }

    [HttpPost]
    public async Task<ActionResult> Post(HotDeals hotDeal){ 
        await _service.AddAsync(hotDeal); 
        return Ok(); 
    }

    [HttpPut]
    public async Task<ActionResult> Put(string id, HotDeals hotDeal){ 
        await _service.UpdateAsync(id, hotDeal); 
        return Ok(); 
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(string id) { 
        await _service.DeleteAsync(id); 
        return Ok(); 
    }

    [HttpGet("verify")]
    public async Task<IActionResult> VerifyDbConnection()
    {
        var hotDeals = await _service.GetAllAsync();
        
        // Log the data to the debug console
        foreach (var hotDeal in hotDeals)
        {
            _logger.LogInformation($"ID: {hotDeal.DestinationId}, Name: {hotDeal.Name}");
        }

        return new JsonResult(hotDeals);
    }
}