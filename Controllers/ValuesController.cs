using Microsoft.AspNetCore.Mvc;


namespace WebApplication10.Controllers;
[Route("api/test")]
[ApiController]
public class ValuesController : ControllerBase
{


    [HttpGet("thread")]
    public IActionResult SimulateBlocking()
    {
        Thread.Sleep(10000);
        return Ok("Thread.Sleep simulation completed.");
    }

    [HttpGet("task")]
    public async Task<IActionResult> SimulateNonBlocking()
    {
        await Task.Delay(10000);
        return Ok("Task.Delay simulation completed.");
    }
}
