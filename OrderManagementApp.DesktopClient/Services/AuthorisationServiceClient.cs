using OrderManagementApp.Service;
using OrderManagementApp.Service.DataLayer;
using OrderManagementApp.ServiceContract;
using System;

namespace OrderManagementApp.DesktopClient.Services
{

    public sealed class AuthorisationServiceClient
    {
        private readonly IAuthorisationService authorisationService;
        private AuthorisationServiceClient()
        {
            // as there is no real backend
            // we instantiate the actual service 
            // here instead of working against a HTTP client oslt
            this.authorisationService = new AuthorisationService(new DataLayer());
        }

        private static readonly Lazy<AuthorisationServiceClient> lazy = new Lazy<AuthorisationServiceClient>(() => new AuthorisationServiceClient());
        public static AuthorisationServiceClient Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public string Authenticate(string username, string password)
        {
            return this.authorisationService.Authenticate(username, password);
        }
    }
}
