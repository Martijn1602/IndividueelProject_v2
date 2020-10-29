using OrderManagementApp.DesktopClient.Models;
using System.Linq;

namespace OrderManagementApp.DesktopClient.Services
{
    public class AuthorisationService : IAuthorisationService
    {
        public User Authenticate(string username, string password)
        {
            using (var context = new OrderManagementContext())
            {
                return context.Users.
                    SingleOrDefault(x => x.Username == username && x.Password == password);
            }
        }
    }
}
