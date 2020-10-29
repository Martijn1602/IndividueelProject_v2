using OrderManagementApp.DesktopClient.Models;
using System;

namespace OrderManagementApp.DesktopClient.ViewModel.Models
{
    public class CustomerViewModel : EntityViewModel<Customer>
    {
        public CustomerViewModel() : base()
        {

        }

        public CustomerViewModel(Customer model) : base(model)
        {

        }

        public int CustomerId
        {
            get { return model.CustomerId; }
        }

        public string FirstName
        {
            get { return model.FirstName; }
            set
            {
                model.FirstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get { return model.LastName; }
            set
            {
                model.LastName = value;
                OnPropertyChanged("LastName");
            }
        }
        public string Street
        {
            get { return model.Street; }
            set
            {
                model.Street = value;
                OnPropertyChanged("Street");
            }
        }
        public string Number
        {
            get { return model.Number; }
            set
            {
                model.Number = value;
                OnPropertyChanged("Number");
            }
        }
        public string Box
        {
            get { return model.Box; }
            set
            {
                model.Box = value;
                OnPropertyChanged("Box");
            }
        }
        public string PostalCode
        {
            get { return model.PostalCode; }
            set
            {
                model.PostalCode = value;
                OnPropertyChanged("PostalCode");
            }
        }
        public string City
        {
            get { return model.City; }
            set
            {
                model.City = value;
                OnPropertyChanged("City");
            }
        }
        public string PhoneNumber
        {
            get { return model.PhoneNumber; }
            set
            {
                model.PhoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }
        public string Mailaddress
        {
            get { return model.MailAddress; }
            set
            {
                model.MailAddress = value;
                OnPropertyChanged("MailAddress");
            }
        }
        public DateTime CreatedAt
        {
            get { return model.CreatedAt; }
            set
            {
                model.CreatedAt = value;
                OnPropertyChanged("CreatedAt");
            }
        }
        public string Remarks
        {
            get { return model.Remarks; }
            set
            {
                model.Remarks = value;
                OnPropertyChanged("Remarks");
            }
        }
    }
}
