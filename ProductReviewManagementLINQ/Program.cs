using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>()
            {
                new Products() { productId = 1, userId = 1, rating = 6, review = "good", isLike = true },
                new Products() { productId = 2, userId = 1, rating = 4, review = "good", isLike = true },
                new Products() { productId = 3, userId = 2, rating = 5, review = "bad", isLike = false },
                new Products() { productId = 1, userId = 3, rating = 6, review = "good", isLike = true },
                new Products() { productId = 5, userId = 1, rating = 6, review = "good", isLike = true },
                new Products() { productId = 3, userId = 1, rating = 4, review = "good", isLike = true },
                new Products() { productId = 7, userId = 2, rating = 5, review = "bad", isLike = false },
                new Products() { productId = 8, userId = 3, rating = 6, review = "good", isLike = true },
                new Products() { productId = 11, userId = 1, rating = 6, review = "good", isLike = true },
                new Products() { productId = 10, userId = 1, rating = 4, review = "bad", isLike = false },
                new Products() { productId = 11, userId = 2, rating = 5, review = "good", isLike = true },
                new Products() { productId = 10, userId = 3, rating = 6, review = "good", isLike = true },
                new Products() { productId = 12, userId = 3, rating = 6, review = "good", isLike = true },
                new Products() { productId = 1, userId = 1, rating = 6, review = "good", isLike = true },
                new Products() { productId = 3, userId = 1, rating = 4, review = "bad", isLike = false },
                new Products() { productId = 11, userId = 2, rating = 5, review = "good", isLike = true },
                new Products() { productId = 5, userId = 3, rating = 6, review = "good", isLike = true }
            };
        }
    }

    }
