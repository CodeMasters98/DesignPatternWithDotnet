using FactroeyMethodSampleWithDIAndApi.Services.Interfaces;

namespace FactroeyMethodSampleWithDIAndApi.Services.Implementations;

public class EmailNotificationService : INotificationService
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"[Email] to {to}: {message}");
    }
}
