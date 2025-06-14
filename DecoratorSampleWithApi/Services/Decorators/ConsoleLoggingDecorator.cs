using DecoratorSampleWithApi.Services.Interfaces;

namespace DecoratorSampleWithApi.Services.Decorators;

public class ConsoleLoggingDecorator : INotificationService
{
    private readonly INotificationService _inner;

    public ConsoleLoggingDecorator(INotificationService inner)
    {
        _inner = inner;
    }

    public async Task SendAsync(string to, string message)
    {
        Console.WriteLine($"[Console Log] Sending to {to}");
        await _inner.SendAsync(to, message);
        Console.WriteLine($"[Console Log] Sent to {to}");
    }
}
