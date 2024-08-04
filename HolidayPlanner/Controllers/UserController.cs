using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _service;
    private readonly ILogger<UserController> _logger;

    public UserController(UserService service, ILogger<UserController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<List<User>>> Get()
    {
        return await _service.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User?>> Get(string id)
    {
        return await _service.GetByIdAsync(id);
    }

    [HttpPost]
    public async Task<ActionResult> Post(User user)
    {
        await _service.AddAsync(user);
        return Ok();
    }

    [HttpPut]
    public async Task<ActionResult> Put(User user)
    {
        await _service.UpdateAsync(user);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(string id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }

    [HttpGet("verify")]
    public async Task<IActionResult> VerifyDbConnection()
    {
        var users = await _service.GetAllAsync();

        // Log the data to the debug console
        foreach (var user in users)
        {
            _logger.LogInformation($"ID: {user.UserId}, Name: {user.Name}, Email: {user.EmailId}");
        }

        return new JsonResult(users);
    }
}