using OrderManagementApp.Service.DataLayer;
using OrderManagementApp.ServiceContract;

namespace OrderManagementApp.Service
{
    public class AuthorisationService : IAuthorisationService
    {
        private readonly IDataLayer dataLayer;

        public AuthorisationService(IDataLayer dataLayer)
        {
            this.dataLayer = dataLayer;
        }
        public string Authenticate(string username, string password)
        {
            var result = dataLayer.GetUser(username, password);

            if(result == null) {
                // better: Throw exception
                return "NOT AUTHENTICATED";
            }

            // better: return JWT Token / Token based on the resulting user
            return "AUTHENTICATED";
        }
    }
}
