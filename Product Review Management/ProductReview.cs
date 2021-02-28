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
        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return obj is ProductReview review &&
                   ProductID == review.ProductID &&
                   UserID == review.UserID &&
                   Rating == review.Rating &&
                   Review == review.Review &&
                   IsLike == review.IsLike;
        }
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(ProductID, UserID, Rating, Review, IsLike);
        }
    }
}
