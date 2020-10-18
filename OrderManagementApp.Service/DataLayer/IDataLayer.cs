using OrderManagementApp.Service.Models;

namespace OrderManagementApp.Service.DataLayer
{
    public interface IDataLayer
    {
        User GetUser(string username, string password);
    }
}
