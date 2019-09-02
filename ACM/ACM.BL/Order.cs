using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }


        /// <summary>
        /// Validates Product
        /// </summary>
        /// <return></return>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <returns></returns>
        public Customer Retrieve(int orderId)
        {
            // code that retrieves the defined customer

            return new Customer();
        }


        /// <summary>
        /// Retieve all orders.
        /// </summary>
        public List<Customer> Retrieve()
        {
            // code that retrieves all of the customers

            return new List<Customer>();
        }


        /// <summary>
        /// Saves the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code that saves the difined customer

            return true;
        }
    }
}
