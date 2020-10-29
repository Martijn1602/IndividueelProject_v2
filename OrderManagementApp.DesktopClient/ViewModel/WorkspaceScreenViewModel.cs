using OrderManagementApp.DesktopClient.Services;
using OrderManagementApp.DesktopClient.Utilties;
using OrderManagementApp.DesktopClient.Utilties.EventAggregator;
using System.Windows.Input;

namespace OrderManagementApp.DesktopClient.ViewModel
{
    public class WorkspaceScreenViewModel : ViewModel
    {
        private IEventAggregator eventAggregator;

        public WorkspaceScreenViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            this.activeWorkspace = new DashboardScreenViewModel();
            WireCommands();
        }

        private void WireCommands()
        {
            this.ViewOrders = new RelayCommand<object>(_ => this.ActiveWorkspace = new OrderScreenViewModel());
            this.ViewDashboard = new RelayCommand<object>(_ => this.ActiveWorkspace = new DashboardScreenViewModel());
            this.ViewDataManagement = new RelayCommand<object>(_ => this.ActiveWorkspace = new DataManagementScreenViewModel());
        }

        public ICommand ViewOrders { get; private set; }

        public ICommand ViewDataManagement { get; private set; }

        public ICommand ViewDashboard { get; private set; }

        private ViewModel activeWorkspace;

        public ViewModel ActiveWorkspace
        {
            get { return activeWorkspace; }
            set 
            { 
                activeWorkspace = value;
                OnPropertyChanged("ActiveWorkspace");
            }
        }
    }
}
