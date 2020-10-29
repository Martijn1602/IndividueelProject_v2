
using OrderManagementApp.DesktopClient.Events;
using OrderManagementApp.DesktopClient.Services;
using OrderManagementApp.DesktopClient.Utilties;
using OrderManagementApp.DesktopClient.Utilties.EventAggregator;
using System.Windows.Input;

namespace OrderManagementApp.DesktopClient.ViewModel
{
    public class LoginScreenViewModel : ViewModel
    {

        #region Fields
        
        private string username;

        #endregion

        #region Constructors

        public LoginScreenViewModel(IEventAggregator eventAggregator, IAuthorisationService authorisationService)
        {
            this.eventAggregator = eventAggregator;
            this.authorisationService = authorisationService;
            this.LoginCommand = new RelayCommand<object>(Login);
          
        }

        #endregion

        #region Properties

        public string Username
        {
            get { return username; }
            set 
            { 
                username = value;
                OnPropertyChanged("Username");
            }
        }

        public string SecurePassword { private get; set; }

        private bool showLoginError;
        private IEventAggregator eventAggregator;
        private IAuthorisationService authorisationService;

        public bool ShowLoginError
        {
            get { return showLoginError; }
            set { 
                showLoginError = value;
                OnPropertyChanged("ShowLoginError");
            }
        }


        public ICommand LoginCommand { get; }

        #endregion

        #region Private methods

        private void Login(object _)
        {
            ShowLoginError = false;

            var user = authorisationService.Authenticate(username, SecurePassword);

            // if (user != null)
            //{
                eventAggregator.PostMessage<LoginEvent>(new LoginEvent(user));
            //}

            ShowLoginError = true;
        }

        #endregion

    }
}
