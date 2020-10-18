using OrderManagementApp.DesktopClient.Services;
using OrderManagementApp.DesktopClient.Utilties;
using OrderManagementApp.DesktopClient.Views;
using System.Security;
using System.Windows.Input;

namespace OrderManagementApp.DesktopClient.ViewModel
{
    public class LoginViewModel : ViewModel
    {

        #region Fields
        
        private string username;

        #endregion

        #region Constructors

        public LoginViewModel()
        {
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

            AuthorisationServiceClient client = AuthorisationServiceClient.Instance;
            string token = client.Authenticate(username, SecurePassword);

            if (token == "AUTHENTICATED")
            {
                MainView view = new MainView();
                view.DataContext = new MainViewModel();
                view.Show();
                OnPropertyChanged("CLOSE_VIEW");
                return;
            }

            ShowLoginError = true;
        }

        #endregion

    }
}
