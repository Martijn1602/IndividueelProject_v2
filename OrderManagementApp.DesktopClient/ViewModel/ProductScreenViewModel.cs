using OrderManagementApp.DesktopClient.Models;
using OrderManagementApp.DesktopClient.Services;
using OrderManagementApp.DesktopClient.ViewModel.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace OrderManagementApp.DesktopClient.ViewModel
{
    public class ProductScreenViewModel : CRUDViewModel<Product, ProductViewModel>
    {
        public ProductScreenViewModel(IRepository<Product> repository) : base (repository)
        {

        }

        protected override void FetchEntities()
        {
            var models = repository.GetEntities();
            Entities = new ObservableCollection<ProductViewModel>(models.Select(x => new ProductViewModel(x)));
        }
    }
}