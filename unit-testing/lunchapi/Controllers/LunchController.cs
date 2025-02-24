using lunchapi.Models;
using lunchapi.Services;
using Microsoft.AspNetCore.Mvc;


namespace lunchapi.Controllers;

[ApiController]
public class LunchController : ControllerBase
{
    private readonly LunchService _lunchService;
    public LunchController(LunchService lunchService)
    {
        _lunchService = lunchService;
    }

    [HttpGet("lunch")]
    public IActionResult GetLunch()
    {
        var data = _lunchService.GetLunch();
        return Ok(data);
    }
}