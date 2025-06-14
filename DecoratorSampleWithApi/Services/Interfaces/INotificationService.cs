namespace DecoratorSampleWithApi.Services.Interfaces;

public interface INotificationService
{
    Task SendAsync(string to, string message);
}
