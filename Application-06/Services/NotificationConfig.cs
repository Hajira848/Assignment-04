using System;

namespace Application_06.Services 
{
    public class NotificationConfig
    {
        public int DefaultNumberOfNotifications { get; set; } = 3;
        public string NotificationStyle { get; set; } = "Detailed"; 
        public event Action? OnConfigChanged;

        public void NotifyChanged() => OnConfigChanged?.Invoke();
    }
}

