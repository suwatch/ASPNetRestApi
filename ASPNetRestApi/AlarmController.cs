using Microsoft.AspNetCore.Mvc;

[Route("api/v2/[controller]")]
public class AlarmController : Controller
{
    [HttpGet]
    [Route("{**catchAll}")]
    public IActionResult CatchAll()
    {
        return NoContent();
    }
}