using DecoratorSampleWithApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorSampleWithApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotificationController : ControllerBase
{
    private readonly INotificationService _notificationService;

    public NotificationController(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    [HttpPost]
    public async Task<IActionResult> Send([FromQuery] string to, [FromQuery] string message)
    {
        await _notificationService.SendAsync(to, message);
        return Ok("Notification sent.");
    }
}
