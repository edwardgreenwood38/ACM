using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }


        /// <summary>
        /// Validates Order Item
        /// </summary>
        /// <return></return>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve one Order Item.
        /// </summary>
        /// <returns></returns>
        public Customer Retrieve(int orderItemId)
        {
            // code that retrieves the defined customer

            return new Customer();
        }


        /// <summary>
        /// Retieve all order Items.
        /// </summary>
        public List<Customer> Retrieve()
        {
            // code that retrieves all of the customers

            return new List<Customer>();
        }


        /// <summary>
        /// Saves the current order item.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code that saves the difined customer

            return true;
        }
    }
}
