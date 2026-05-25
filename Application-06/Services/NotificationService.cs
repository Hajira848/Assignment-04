using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application_06.Services
{
    public class NotificationService
    {
        private readonly NotificationConfig _config;
        public NotificationService(NotificationConfig config)
        {
            _config = config;
        }

        public async Task<List<string>> GetNotificationsAsync(int? numberOfNotifications =
            null)
        {
            int count = numberOfNotifications ?? _config.DefaultNumberOfNotifications;

            await Task.Delay(100);

            var alerts = new List<string>();
            for (int i = 1; i <= count; i++)
            {
                alerts.Add($"Notification system log alert sequence #{i}:" +
                    $" System performance parameters are running optimal.");
            }

            return alerts;
        }
    }
}

