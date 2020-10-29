
using OrderManagementApp.DesktopClient.Models;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagementApp.DesktopClient.Services
{
    public class Repository<M> : IRepository<M> where M : class, IModel
    {
        public IEnumerable<M> GetEntities()
        {
            using (var context = new OrderManagementContext())
            {
                return context.Set<M>().ToList();
            }
        }

        public void RemoveEntity(M m)
        {
            using (var context = new OrderManagementContext())
            {
                context.Set<M>().Remove(m);
                context.SaveChanges();
            }
        }

        public int SaveEntity(M m)
        {
            using (var context = new OrderManagementContext())
            {
                if (m.GetId() != 0)
                {
                    context.Set<M>().Update(m);
                }
                else
                {
                    var added = context.Set<M>().Add(m);
                    m = added.Entity;
                }

                context.SaveChanges();
                return m.GetId();
            }
        }
    }
}
