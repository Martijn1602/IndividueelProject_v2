using System.Collections.Generic;

namespace OrderManagementApp.Service.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public List<Product> Products { get; } = new List<Product>();
    }
}
