using OrderManagementApp.DesktopClient.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace OrderManagementApp.DesktopClient.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginScreenView : UserControl
    {
        public LoginScreenView()
        {
            InitializeComponent();
        }
   
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            { ((LoginScreenViewModel)this.DataContext).SecurePassword = ((PasswordBox)sender).Password; }
        }
    }
}
