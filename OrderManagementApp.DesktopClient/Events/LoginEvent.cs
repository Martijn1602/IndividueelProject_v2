using OrderManagementApp.DesktopClient.Models;

namespace OrderManagementApp.DesktopClient.Events
{
    public class LoginEvent
    {
        public LoginEvent(User user)
        {
            this.User = user;
        }

        public User User { get; }

    }
}
