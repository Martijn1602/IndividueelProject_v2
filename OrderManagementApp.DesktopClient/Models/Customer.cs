using System;
using System.Collections.Generic;

namespace OrderManagementApp.DesktopClient.Models
{
    public class Customer : IModel
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }

        public string Box { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string PhoneNumber { get; set; }

        public string MailAddress { get; set; }

        public DateTime CreatedAt { get; set; }
        
        public string Remarks { get; set; }

        public List<Order> Orders { get; } = new List<Order>();

        public int GetId()
        {
            return CustomerId;
        }

        public void SetId(int id)
        {
            CustomerId = id;
        }
    }
}
