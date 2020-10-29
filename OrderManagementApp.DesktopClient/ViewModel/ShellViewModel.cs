using OrderManagementApp.DesktopClient.Events;
using OrderManagementApp.DesktopClient.Services;
using OrderManagementApp.DesktopClient.Utilties.EventAggregator;

namespace OrderManagementApp.DesktopClient.ViewModel
{
    public class ShellViewModel : ViewModel
    {
        private IEventAggregator eventAggregator = new EventAggregator();

        public ShellViewModel()
        {
            var loginViewModel = new LoginScreenViewModel(eventAggregator, new AuthorisationService());
            eventAggregator.RegisterHandler<LoginEvent>(LoginHandler);
            this.activeViewModel = loginViewModel;
        }

        private object activeViewModel;

        public object ActiveViewModel
        {
            get { return activeViewModel; }
            set 
            { 
                activeViewModel = value;
                OnPropertyChanged("ActiveViewModel");
            }
        }

        private void LoginHandler(LoginEvent loginEvent)
        {
            this.ActiveViewModel = new WorkspaceScreenViewModel(eventAggregator);
        }
    }
}
