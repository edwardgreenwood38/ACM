using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }


        /// <summary>
        /// Validates Product
        /// </summary>
        /// <return></return>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve one product.
        /// </summary>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // code that retrieves the defined customer

            return new Customer();
        }


        /// <summary>
        /// Retieve all products.
        /// </summary>
        public List<Customer> Retrieve()
        {
            // code that retrieves all of the customers

            return new List<Customer>();
        }


        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code that saves the difined customer

            return true;
        }
    }
}
