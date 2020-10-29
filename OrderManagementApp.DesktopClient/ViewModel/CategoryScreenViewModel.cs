using OrderManagementApp.DesktopClient.Models;
using OrderManagementApp.DesktopClient.Services;
using OrderManagementApp.DesktopClient.ViewModel.Models;

namespace OrderManagementApp.DesktopClient.ViewModel
{
    public class CategoryScreenViewModel : CRUDViewModel<Category, CategoryViewModel>
    {
        public CategoryScreenViewModel(IRepository<Category> repository) : base(repository)
        {

        }
        protected override CategoryViewModel GetViewModel(Category model)
        {
            return new CategoryViewModel(model);
        }
    }
}