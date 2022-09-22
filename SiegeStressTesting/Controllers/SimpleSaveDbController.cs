using Microsoft.AspNetCore.Mvc;

namespace SiegeStressTesting.Controllers;

[ApiController]
[Route("[controller]")]
public class SimpleSaveDbController : ControllerBase
{
    private readonly ILogger<SimpleSaveDbController> _logger;
    private readonly SiegeDbContext _siegeDbContext;

    public SimpleSaveDbController(
        ILogger<SimpleSaveDbController> logger,
        SiegeDbContext context)
    {
        _logger = logger;
        _siegeDbContext = context;
    }

    [HttpPost(Name = nameof(SaveSimpleDataInDb))]
    public async Task<IActionResult> SaveSimpleDataInDb(SaveModel saveModel)
    {
        _siegeDbContext.SaveModels.Add(saveModel);
        await _siegeDbContext.SaveChangesAsync();
        return Ok();
    }
}

public class SaveModel
{
    public Guid Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
}