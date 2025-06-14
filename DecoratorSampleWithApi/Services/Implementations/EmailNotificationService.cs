using DecoratorSampleWithApi.Services.Interfaces;

namespace DecoratorSampleWithApi.Services.Implementations;

public class EmailNotificationService : INotificationService
{
    public Task SendAsync(string to, string message)
    {
        // Simulate sending email
        Console.WriteLine($"Email sent to {to} with message: {message}");
        return Task.CompletedTask;
    }
}
