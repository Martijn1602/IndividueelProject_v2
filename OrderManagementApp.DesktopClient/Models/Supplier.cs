namespace OrderManagementApp.DesktopClient.Models
{
    public class Supplier : IModel
    {
        public int SupplierId { get; set; }

        public string ContactName { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }

        public string Box { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string PhoneNumber { get; set; }

        public string MailAddress { get; set; }

        public int GetId()
        {
            return SupplierId;
        }

        public void SetId(int id)
        {
            SupplierId = id;
        }
    }
}
