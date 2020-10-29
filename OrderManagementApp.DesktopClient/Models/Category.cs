using System.Collections.Generic;

namespace OrderManagementApp.DesktopClient.Models
{
    public class Category : IModel
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public List<Product> Products { get; } = new List<Product>();

        public int GetId()
        {
            return CategoryId;
        }

        public void SetId(int id)
        {
            CategoryId = id;
        }
    }
}
