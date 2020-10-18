namespace OrderManagementApp.ServiceContract
{
    public interface IAuthorisationService
    {
        string Authenticate(string username, string password);
    }
}
