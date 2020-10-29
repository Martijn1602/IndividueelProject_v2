using OrderManagementApp.DesktopClient.Models;
using System;

namespace OrderManagementApp.DesktopClient.ViewModel.Models
{
    public class CategoryViewModel : EntityViewModel<Category>
    {
        public CategoryViewModel() : base()
        {

        }

        public CategoryViewModel(Category model) : base(model)
        {

        }

        public int CategoryId
        {
            get { return model.CategoryId; }
        }

        public string Name
        {
            get { return model.Name; }
            set 
            { 
                model.Name = value;
                OnPropertyChanged("Name");
            }
        }
    }
}
