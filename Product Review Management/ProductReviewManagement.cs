using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Review_Management
{
    public class ProductReviewManagement
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            List<ProductReview> ProductReviewsList = new List<ProductReview>()
            {
                new ProductReview(){ProductID = 1, UserID = 1, Rating = 5, Review = "good", IsLike = true},
                new ProductReview(){ProductID = 2, UserID = 1, Rating = 5, Review = "good", IsLike = true},
                new ProductReview(){ProductID = 3, UserID = 2, Rating = 5, Review = "good", IsLike = true},
                new ProductReview(){ProductID = 4, UserID = 2, Rating = 4, Review = "bad", IsLike = false},
                new ProductReview(){ProductID = 5, UserID = 3, Rating = 5, Review = "bad", IsLike = true},
                new ProductReview(){ProductID = 6, UserID = 3, Rating = 4, Review = "good", IsLike = false},
                new ProductReview(){ProductID = 7, UserID = 4, Rating = 5, Review = "bad", IsLike = true},
                new ProductReview(){ProductID = 8, UserID = 4, Rating = 4, Review = "good", IsLike = true},
                new ProductReview(){ProductID = 9, UserID = 5, Rating = 5, Review = "bad", IsLike = false},
                new ProductReview(){ProductID = 10, UserID = 5, Rating = 2.2, Review = "good", IsLike = false},
                new ProductReview(){ProductID = 11, UserID = 6, Rating = 3, Review = "nice", IsLike = true},
                new ProductReview(){ProductID = 12, UserID = 6, Rating = 5, Review = "bad", IsLike = true},
                new ProductReview(){ProductID = 13, UserID = 7, Rating = 5, Review = "good", IsLike = false},
                new ProductReview(){ProductID = 14, UserID = 7, Rating = 3.4, Review = "nice", IsLike = true},
                new ProductReview(){ProductID = 15, UserID = 8, Rating = 5, Review = "bad", IsLike = false},
                new ProductReview(){ProductID = 16, UserID = 8, Rating = 5, Review = "good", IsLike = true},
                new ProductReview(){ProductID = 17, UserID = 9, Rating = 1.2, Review = "good", IsLike = true},
                new ProductReview(){ProductID = 18, UserID = 9, Rating = 0, Review = "good", IsLike = false},
                new ProductReview(){ProductID = 19, UserID = 10, Rating = 0, Review = "bad", IsLike = true},
                new ProductReview(){ProductID = 20, UserID = 10, Rating = 5, Review = "good", IsLike = false},
                new ProductReview(){ProductID = 21, UserID = 11, Rating = 0, Review = "average", IsLike = true},
                new ProductReview(){ProductID = 22, UserID = 11, Rating = 5, Review = "bad", IsLike = false},
                new ProductReview(){ProductID = 23, UserID = 12, Rating = 1, Review = "good", IsLike = true},
                new ProductReview(){ProductID = 24, UserID = 12, Rating = 1, Review = "average", IsLike = true},
                new ProductReview(){ProductID = 25, UserID = 12, Rating = 1, Review = "average", IsLike = true},
            };

            foreach (var product in ProductReviewsList)
            {
                Console.WriteLine("Product ID".PadRight(10) + ":" + product.ProductID);
                Console.WriteLine("User ID".PadRight(10) + ":" + product.UserID);
                Console.WriteLine("Rating".PadRight(10) + ":" + product.Rating);
                Console.WriteLine("Review".PadRight(10) + ":" + product.Review);
                Console.WriteLine("Liked".PadRight(10) + ":" + product.IsLike);
                Console.WriteLine();
            }
        }

        public List<ProductReview> RetrieveTop3ProductsByRating(List<ProductReview> productReviewsList)
        {
            return productReviewsList.OrderByDescending(product => product.Rating).Take(3).ToList();
        }
    }
}
