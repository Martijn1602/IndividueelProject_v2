using OrderManagementApp.DesktopClient.Models;
using OrderManagementApp.DesktopClient.Services;
using OrderManagementApp.DesktopClient.ViewModel.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace OrderManagementApp.DesktopClient.ViewModel
{
    public class CategoryScreenViewModel : CRUDViewModel<Category, CategoryViewModel>
    {
        public CategoryScreenViewModel(IRepository<Category> repository) : base(repository)
        {

        }
        protected override void FetchEntities()
        {
            var models = repository.GetEntities();
            Entities = new ObservableCollection<CategoryViewModel>(models.Select(x => new CategoryViewModel(x)));
        }
    }
}