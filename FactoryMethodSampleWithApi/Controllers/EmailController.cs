using FactoryMethodSampleWithApi.Dtos;
using FactoryMethodSampleWithApi.Services.Factory;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethodSampleWithApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class EmailController : ControllerBase
{
    [HttpPost]
    public IActionResult Send([FromBody] NotificationDto request)
    {
        var service = NotificationServiceFactory.CreateNotificationService(Enums.NotificationType.Email);
        service.Send(request.To, request.Message);
        return Ok();
    }
}
