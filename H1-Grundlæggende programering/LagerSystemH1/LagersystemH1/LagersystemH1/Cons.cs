using System;



namespace Lagersystem.DB
{
    public class Product
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int ItemStock { get; set; }
        //public int ProductEmployeeID { get; set; }
        public DateTime ProductCreatedDate { get; set; }

        
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }

        // Constructor
        public Product(int itemid, string itemname, int itemstock)
        {
            ItemID = itemid;
            ItemName = itemname;
            ItemStock = itemstock;
            ProductCreatedDate = DateTime.Now;
        }

        /*public Customer(int customerID, string firstName, string lastName, string address, int zipCode, string city)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            ZipCode = zipCode;
            City = city;

        }
        */
    }
}
