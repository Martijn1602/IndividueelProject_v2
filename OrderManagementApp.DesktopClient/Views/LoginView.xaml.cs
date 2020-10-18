using OrderManagementApp.DesktopClient.ViewModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace OrderManagementApp.DesktopClient.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
            ((INotifyPropertyChanged)this.DataContext).PropertyChanged += LoginView_PropertyChanged;
        }

        private void LoginView_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "CLOSE_VIEW")
            {
                this.Close();
            }
        }
   
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            { ((LoginViewModel)this.DataContext).SecurePassword = ((PasswordBox)sender).Password; }
        }
    }
}
