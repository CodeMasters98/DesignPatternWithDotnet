using FactoryMethodSampleWithApi.Enums;
using FactoryMethodSampleWithApi.Services.Implementations;
using FactoryMethodSampleWithApi.Services.Interfaces;

namespace FactoryMethodSampleWithApi.Services.Factory;

public class NotificationServiceFactory
{
    public static INotificationService CreateNotificationService(NotificationType type)
    {
        return type switch
        {
            NotificationType.Email => new EmailNotificationService(),
            NotificationType.Sms => new SmsNotificationService(),
            _ => throw new NotImplementedException()
        };
    }
}