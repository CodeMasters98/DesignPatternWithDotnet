using DecoratorSampleWithApi.Services.Interfaces;

namespace DecoratorSampleWithApi.Services.Decorators;

public class LoggingNotificationServiceDecorator : INotificationService
{
    private readonly INotificationService _inner;
    private readonly ILogger<LoggingNotificationServiceDecorator> _logger;

    public LoggingNotificationServiceDecorator(INotificationService inner, ILogger<LoggingNotificationServiceDecorator> logger)
    {
        _inner = inner;
        _logger = logger;
    }

    public async Task SendAsync(string to, string message)
    {
        _logger.LogInformation($"Sending notification to {to}...");
        await _inner.SendAsync(to, message);
        _logger.LogInformation($"Notification sent to {to}");
    }
}
