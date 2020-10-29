using System.Collections.Generic;

namespace OrderManagementApp.Service.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public List<Order> Orders { get; set; }
    }
}
