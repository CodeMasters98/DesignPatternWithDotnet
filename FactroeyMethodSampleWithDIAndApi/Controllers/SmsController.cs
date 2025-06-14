using FactroeyMethodSampleWithDIAndApi.Dtos;
using FactroeyMethodSampleWithDIAndApi.Services.Factory;
using Microsoft.AspNetCore.Mvc;

namespace FactroeyMethodSampleWithDIAndApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class SmsController : ControllerBase
{

    private readonly INotificationServiceFactory _factory;
    public SmsController(INotificationServiceFactory factory)
    {
        _factory = factory;
    }


    [HttpPost]
    public IActionResult Send([FromBody] NotificationDto request)
    {
        var service = _factory.Create(Enums.NotificationType.Sms);
        service.Send(request.To, request.Message);
        return Ok();
    }
}
