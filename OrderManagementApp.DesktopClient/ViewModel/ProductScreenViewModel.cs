using OrderManagementApp.DesktopClient.Models;
using OrderManagementApp.DesktopClient.Services;
using OrderManagementApp.DesktopClient.ViewModel.Models;

namespace OrderManagementApp.DesktopClient.ViewModel
{
    public class ProductScreenViewModel : CRUDViewModel<Product, ProductViewModel>
    {
        public ProductScreenViewModel(IRepository<Product> repository) : base (repository)
        {

        }

        protected override ProductViewModel GetViewModel(Product model)
        {
            return new ProductViewModel(model);
        }
    }
}