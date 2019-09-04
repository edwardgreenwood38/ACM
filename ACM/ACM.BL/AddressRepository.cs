using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            // Create the instance of the Address class
            // pass in the requested id
            Address address = new Address(addressId);

            // code that retrieves the defined address

            // temporary hard coded values to return a populated address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;
        }


        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // code that retrieves the defined address for the customer

            // temporary hasr code values to return a set of addresses for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };

            addressList.Add(address);


            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };

            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool Save (Address address)
        {
            // code that saves the passed in address

            return true;
        }
    }
}
