using OrderManagementApp.DesktopClient.Models;
using System.Collections.Generic;

namespace OrderManagementApp.DesktopClient.Services
{
    public interface IRepository<M>
    {
        IEnumerable<M> GetEntities();

        void RemoveEntity(M m);

        int SaveEntity(M m);
    }
}
