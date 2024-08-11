using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class BookingController : ControllerBase
{
    private readonly BookingService _service;
    private readonly ILogger<BookingController> _logger;

    public BookingController(BookingService service, ILogger<BookingController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<List<Booking>>> Get(){
        return await _service.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Booking?>> Get(string id){
        if(string.IsNullOrEmpty(id))
            return BadRequest("Id is required");
        return await _service.GetByIdAsync(id);
    }

    [HttpPost]
    public async Task<ActionResult> Post(Booking booking){ 
        if(!ModelState.IsValid) 
            return BadRequest(ModelState);
        await _service.AddAsync(booking); 
        return Ok(); 
    }

    [HttpPut]
    public async Task<ActionResult> Put(Booking booking){ 
        if(!ModelState.IsValid) 
            return BadRequest(ModelState);
        await _service.UpdateAsync(booking); 
        return Ok(); 
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(string id){ 
        if(string.IsNullOrEmpty(id))
            return BadRequest("Id is required");
        await _service.DeleteAsync(id); 
        return Ok(); 
    }

    [HttpGet("verify")]
    public async Task<IActionResult> VerifyDbConnection()
    {
       var bookings = await _service.GetAllAsync();
        
        // Log the data to the debug console
        foreach (var booking in bookings)
        {
            _logger.LogInformation($"ID: {booking.BookingId}, DestinationName: {booking.DestinationName}, TotalCharges: {booking.TotalCharges}");
        }

        return new JsonResult(bookings);
    }
}