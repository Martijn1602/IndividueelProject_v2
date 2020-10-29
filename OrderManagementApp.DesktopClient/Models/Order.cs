using System;

namespace OrderManagementApp.DesktopClient.Models
{
    public class Order : IModel
    {
        public int OrderId { get; set; }

        public DateTime CreatedAt { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }


        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public int GetId()
        {
            return OrderId;
        }

        public void SetId(int id)
        {
            OrderId = id;
        }
    }
}
