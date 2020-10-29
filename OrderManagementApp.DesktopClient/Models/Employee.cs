using System.Collections.Generic;

namespace OrderManagementApp.DesktopClient.Models
{
    public class Employee : IModel
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public List<Order> Orders { get; set; }

        public int GetId()
        {
            return EmployeeId;
        }

        public void SetId(int id)
        {
            EmployeeId = id;
        }
    }
}
