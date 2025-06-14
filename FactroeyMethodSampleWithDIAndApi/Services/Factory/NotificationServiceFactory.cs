using FactroeyMethodSampleWithDIAndApi.Enums;
using FactroeyMethodSampleWithDIAndApi.Services.Implementations;
using FactroeyMethodSampleWithDIAndApi.Services.Interfaces;

namespace FactroeyMethodSampleWithDIAndApi.Services.Factory;

public interface INotificationServiceFactory
{
    INotificationService Create(NotificationType type);
}

public class NotificationServiceFactory : INotificationServiceFactory
{
    private readonly IServiceProvider _provider;

    public NotificationServiceFactory(IServiceProvider provider)
    {
        _provider = provider;
    }

    public INotificationService Create(NotificationType type)
    {
        return type switch
        {
            NotificationType.Email => _provider.GetRequiredService<EmailNotificationService>(),
            NotificationType.Sms => _provider.GetRequiredService<SmsNotificationService>(),
            _ => throw new NotImplementedException()
        };
    }
}
