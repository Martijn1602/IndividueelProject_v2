using System.ComponentModel;

namespace OrderManagementApp.DesktopClient.ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
