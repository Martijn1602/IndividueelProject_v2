using OrderManagementApp.DesktopClient.ViewModel;
using System.Windows;

namespace OrderManagementApp.DesktopClient
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : Window
    {
        public Shell()
        {
            InitializeComponent();
            this.DataContext = new ShellViewModel();
        }
    }
}
