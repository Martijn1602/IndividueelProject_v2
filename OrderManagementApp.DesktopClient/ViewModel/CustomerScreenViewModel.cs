using OrderManagementApp.DesktopClient.Models;
using OrderManagementApp.DesktopClient.Services;
using OrderManagementApp.DesktopClient.ViewModel.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace OrderManagementApp.DesktopClient.ViewModel
{
    public class CustomerScreenViewModel : CRUDViewModel<Customer, CustomerViewModel>
    {
        public CustomerScreenViewModel(IRepository<Customer> repository) : base(repository)
        {

        }

        protected override void FetchEntities()
        {
            var models = repository.GetEntities();
            Entities = new ObservableCollection<CustomerViewModel>(models.Select(x => new CustomerViewModel(x)));
        }
    }
}