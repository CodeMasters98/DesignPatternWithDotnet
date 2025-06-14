using FactroeyMethodSampleWithDIAndApi.Services.Interfaces;

namespace FactroeyMethodSampleWithDIAndApi.Services.Implementations;

public class SmsNotificationService : INotificationService
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"[SMS] to {to}: {message}");
    }
}