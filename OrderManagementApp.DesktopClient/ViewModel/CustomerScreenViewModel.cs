using OrderManagementApp.DesktopClient.Models;
using OrderManagementApp.DesktopClient.Services;
using OrderManagementApp.DesktopClient.ViewModel.Models;

namespace OrderManagementApp.DesktopClient.ViewModel
{
    public class CustomerScreenViewModel : CRUDViewModel<Customer, CustomerViewModel>
    {
        public CustomerScreenViewModel(IRepository<Customer> repository) : base(repository)
        {

        }

        protected override CustomerViewModel GetViewModel(Customer model)
        {
            return new CustomerViewModel(model);
        }
    }
}