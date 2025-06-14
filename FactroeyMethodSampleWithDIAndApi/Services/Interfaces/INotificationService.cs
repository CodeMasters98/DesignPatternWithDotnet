namespace FactroeyMethodSampleWithDIAndApi.Services.Interfaces;

public interface INotificationService
{
    void Send(string to, string message);
}
