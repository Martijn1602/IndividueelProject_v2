using OrderManagementApp.DesktopClient.Models;

namespace OrderManagementApp.DesktopClient.Services
{
    public interface IAuthorisationService
    {
        User Authenticate(string username, string password);
    }
}
