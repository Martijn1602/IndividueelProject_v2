using OrderManagementApp.DesktopClient.Models;

namespace OrderManagementApp.DesktopClient.ViewModel.Models
{
    public class SupplierViewModel : EntityViewModel<Supplier>
    {
        public SupplierViewModel()
        {

        }

        public SupplierViewModel(Supplier model) : base(model)
        {

        }

        public int SupplierId
        {
            get { return model.SupplierId; }
        }

        public string ContactName
        {
            get { return model.ContactName; }
            set
            {
                model.ContactName = value;
                OnPropertyChanged("Name");
            }
        }

        // ADD FIELDS HERE
    }
}
