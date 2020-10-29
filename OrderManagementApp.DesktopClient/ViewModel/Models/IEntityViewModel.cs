namespace OrderManagementApp.DesktopClient.ViewModel.Models
{
    public interface IEntityViewModel<M>
    {
        M GetModel();

        void SetEntityId(int id);
    }
}
