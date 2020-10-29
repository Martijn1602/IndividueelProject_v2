using OrderManagementApp.DesktopClient.Services;
using OrderManagementApp.DesktopClient.Utilties;
using OrderManagementApp.DesktopClient.ViewModel.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace OrderManagementApp.DesktopClient.ViewModel
{
    public abstract class CRUDViewModel<M, VM> : ViewModel where VM : IEntityViewModel<M>, new()
    {

        protected readonly IRepository<M> repository;

        public CRUDViewModel(IRepository<M> repository)
        {
            this.repository = repository;
            
            FetchEntities();
            WireCommands();
        }

        protected abstract void FetchEntities();

        private void WireCommands()
        {
            this.Save = new RelayCommand<object>(this.SaveEntity);
            this.Delete = new RelayCommand<object>(this.DeleteEntity);
            this.New = new RelayCommand<object>(this.NewEntity);
        }

        private void DeleteEntity(object obj)
        {
            repository.RemoveEntity(selectedEntity.GetModel());
            Entities.Remove(selectedEntity);
            selectedEntity = default;
        }

        private void SaveEntity(object _)
        {
            int id = repository.SaveEntity(selectedEntity.GetModel());
            selectedEntity.SetEntityId(id);
        }

        private void NewEntity(object _)
        {
            var newVM = new VM();
            Entities.Add(newVM);
            SelectedEntity = newVM;
        }

        public ICommand Save { get; set; }

        public ICommand Delete { get; set; }

        public ICommand New { get; set; }

        public ObservableCollection<VM> Entities { get; set; }

        private VM selectedEntity;

        public VM SelectedEntity
        {
            get { return selectedEntity; }
            set
            {
                selectedEntity = value;
                OnPropertyChanged("SelectedEntity");
            }
        }
    }
}
