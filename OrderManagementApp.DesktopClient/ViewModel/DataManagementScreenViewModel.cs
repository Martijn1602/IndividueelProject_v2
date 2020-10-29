using OrderManagementApp.DesktopClient.Models;
using OrderManagementApp.DesktopClient.Services;
using OrderManagementApp.DesktopClient.Utilties;
using System.Windows.Input;

namespace OrderManagementApp.DesktopClient.ViewModel
{
    public class DataManagementScreenViewModel : ViewModel
    {
        public DataManagementScreenViewModel()
        {
            this.activeViewModel = null;
            WireCommands();
        }
        private void WireCommands()
        {
            this.ViewCustomers = new RelayCommand<object>(_ => this.ActiveViewModel = new CustomerScreenViewModel(new Repository<Customer>()));
            this.ViewSuppliers = new RelayCommand<object>(_ => this.ActiveViewModel = new SupplierScreenViewModel(new Repository<Supplier>()));
            this.ViewProducts = new RelayCommand<object>(_ => this.ActiveViewModel = new ProductScreenViewModel(new Repository<Product>()));
            this.ViewCategories = new RelayCommand<object>(_ => this.ActiveViewModel = new CategoryScreenViewModel(new Repository<Category>()));
        }

        public ICommand ViewCustomers { get; private set; }

        public ICommand ViewProducts { get; private set; }

        public ICommand ViewSuppliers { get; private set; }

        public ICommand ViewCategories { get; private set; }


        private ViewModel activeViewModel;

        public ViewModel ActiveViewModel
        {
            get { return activeViewModel; }
            set
            {
                activeViewModel = value;
                OnPropertyChanged("ActiveViewModel");
            }
        }
    }
}
