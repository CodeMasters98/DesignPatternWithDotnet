using FactoryMethodSampleWithApi.Services.Interfaces;

namespace FactoryMethodSampleWithApi.Services.Implementations;

public class SmsNotificationService : INotificationService
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"SMS sent to {to}: {message}");
    }
}
