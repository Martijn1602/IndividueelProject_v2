using System;

namespace OrderManagementApp.Service.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime CreatedAt { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }


        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

    }
}
