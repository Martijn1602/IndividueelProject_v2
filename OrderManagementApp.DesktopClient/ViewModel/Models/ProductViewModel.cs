using OrderManagementApp.DesktopClient.Models;

namespace OrderManagementApp.DesktopClient.ViewModel.Models
{
    public class ProductViewModel : EntityViewModel<Product>
    {

        public ProductViewModel()
        {

        }

        public ProductViewModel(Product model) : base(model)
        {

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

        public decimal PurchasePrice
        {
            get { return model.PurchasePrice; }
            set
            {
                model.PurchasePrice = value;
                OnPropertyChanged("PurchasePrice");
            }
        }

        public string Category
        {
            get 
            {

                if (model.Category != null)
                {
                    return model.Category.Name;
                }

                return null;
            }
        }

        public int CategoryId
        {
            get { return model.CategoryId;  }
            set 
            { 
                model.CategoryId = value;
                OnPropertyChanged("CategoryId");
            }
        }

        public int SupplierId
        {
            get { return model.SupplierId; }
            set
            {
                model.SupplierId = value;
                OnPropertyChanged("SupplierId");
            }
        }


    }
}
