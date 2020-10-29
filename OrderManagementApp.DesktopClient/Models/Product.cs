using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementApp.DesktopClient.Models
{
    public class Product : IModel
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal PurchasePrice { get; set; }

        public decimal Margin { get; set; }

        public int Quantity { get; set; }

        public int VATPercentage { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int GetId()
        {
            return ProductId;
        }

        public void SetId(int id)
        {
            ProductId = id;
        }
    }
}
