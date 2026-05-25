using System;

namespace Application_05.Services
{
    public class AuthenticationStateService
    {
        // Property tracking whether the user is logged into the session
        public bool IsAuthenticated { get; private set; } = false;

        // Custom event triggered whenever the user changes their login state
        public event Action? OnStateChanged;

        // Simulates a user logging into the application framework
        public void LogIn()
        {
            if (!IsAuthenticated)
            {
                IsAuthenticated = true;
                NotifyStateChanged();
            }
        }

        // Simulates logging the user out and flushing session flags
        public void LogOut()
        {
            if (IsAuthenticated)
            {
                IsAuthenticated = false;
                NotifyStateChanged();
            }
        }

        // Broadcaster method that alerts all listening components to refresh their UI
        private void NotifyStateChanged() => OnStateChanged?.Invoke();
    }
}