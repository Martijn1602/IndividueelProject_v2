using OrderManagementApp.DesktopClient.Models;
using OrderManagementApp.DesktopClient.Services;
using OrderManagementApp.DesktopClient.ViewModel.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace OrderManagementApp.DesktopClient.ViewModel
{
    public class SupplierScreenViewModel : CRUDViewModel<Supplier, SupplierViewModel>
    {
        public SupplierScreenViewModel(IRepository<Supplier> repository) : base(repository)
        {

        }

        protected override void FetchEntities()
        {
            var models = repository.GetEntities();
            Entities = new ObservableCollection<SupplierViewModel>(models.Select(x => new SupplierViewModel(x)));
        }
    }
}