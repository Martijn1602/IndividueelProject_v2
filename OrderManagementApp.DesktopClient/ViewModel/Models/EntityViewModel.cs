using OrderManagementApp.DesktopClient.Models;
using System;

namespace OrderManagementApp.DesktopClient.ViewModel.Models
{
    public abstract class EntityViewModel<M> : ViewModel, IEntityViewModel<M> where M : IModel, new()
    {
        protected M model;
        public EntityViewModel()
        {
            model = new M();
        }

        public EntityViewModel(M model)
        {
            this.model = model;
        }

        public M GetModel()
        {
            return model;
        }

        public void SetEntityId(int id)
        {
            model.SetId(id);
            OnPropertyChanged("Id");
        }
    }
}
