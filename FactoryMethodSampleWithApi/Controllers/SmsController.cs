using FactoryMethodSampleWithApi.Dtos;
using FactoryMethodSampleWithApi.Services.Factory;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethodSampleWithApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class SmsController : ControllerBase
{
    [HttpPost]
    public IActionResult Send([FromBody] NotificationDto request)
    {
        var service = NotificationServiceFactory.CreateNotificationService(Enums.NotificationType.Sms);
        service.Send(request.To, request.Message);
        return Ok();
    }
}
