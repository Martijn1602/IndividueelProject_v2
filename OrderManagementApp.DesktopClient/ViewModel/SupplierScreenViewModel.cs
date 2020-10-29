using OrderManagementApp.DesktopClient.Models;
using OrderManagementApp.DesktopClient.Services;
using OrderManagementApp.DesktopClient.ViewModel.Models;

namespace OrderManagementApp.DesktopClient.ViewModel
{
    public class SupplierScreenViewModel : CRUDViewModel<Supplier, SupplierViewModel>
    {
        public SupplierScreenViewModel(IRepository<Supplier> repository) : base(repository)
        {

        }

        protected override SupplierViewModel GetViewModel(Supplier model)
        {
            return new SupplierViewModel(model);
        }
    }
}