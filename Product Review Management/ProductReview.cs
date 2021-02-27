using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Review_Management
{
    public class ProductReview
    {
        /// <summary>
        /// Gets or sets the product identifiers variables
        /// </summary>
        /// <value>
        /// The product identifier.
        /// </value>
        public int ProductID{ get; set; }
        public int UserID{ get; set; }
        public double Rating{ get; set; }
        public string Review{ get; set; }
        public bool IsLike{ get; set; }

    }
}
