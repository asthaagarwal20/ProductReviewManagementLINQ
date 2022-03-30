using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementLINQ
{
    internal class Program
    {
        public static void Display(List<Products> result)
        {
            foreach (var product in result)
            {
                Console.WriteLine("Product id is "+product.productId+" User id is "+product.userId+" product rating is "+product.rating);
            }
        }
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>()
            {
                new Products() { productId = 1, userId = 1, rating = 6, review = "good", isLike = true },
                new Products() { productId = 2, userId = 1, rating = 4, review = "good", isLike = true },
                new Products() { productId = 3, userId = 2, rating = 5, review = "bad", isLike = false },
                new Products() { productId = 4, userId = 3, rating = 6, review = "good", isLike = true },
                new Products() { productId = 5, userId = 1, rating = 6, review = "good", isLike = true },
                new Products() { productId = 3, userId = 1, rating = 10, review = "good", isLike = true },
                new Products() { productId = 7, userId = 2, rating = 5, review = "bad", isLike = false },
                new Products() { productId = 8, userId = 3, rating = 6, review = "good", isLike = true },
                new Products() { productId = 11, userId = 1, rating = 12, review = "good", isLike = true },
                new Products() { productId = 10, userId = 1, rating = 4, review = "bad", isLike = false },
                new Products() { productId = 9, userId = 2, rating = 5, review = "good", isLike = true },
                new Products() { productId = 10, userId = 3, rating = 6, review = "good", isLike = true },
                new Products() { productId = 12, userId = 3, rating = 6, review = "good", isLike = true },
                new Products() { productId = 1, userId = 1, rating = 6, review = "good", isLike = true },
                new Products() { productId = 3, userId = 1, rating = 1, review = "bad", isLike = false },
                new Products() { productId = 11, userId = 2, rating = 5, review = "good", isLike = true },
                new Products() { productId = 5, userId = 3, rating = 13, review = "good", isLike = true }
            };
            //uc2
            var result = products.OrderByDescending(x=>x.rating).Take(3);
            Display(result.ToList());
            //uc3
            var tempArray = new int[] { 1, 4, 9 };
            var result1=products.Where(x=>x.rating>3&&tempArray.Contains(x.productId)).ToList();
            Display(result1);
            //uc4
            var result3=products.GroupBy(x=>x.productId).Select (x=>new {productId=x.Key,Count=x.Count()});
            foreach(var item in result3)
            {
                Console.WriteLine("Product id is " + item.productId + " Count is " + item.Count);
            }
            //uc5
            var result4 = (from product in products select product).Select(x=>new { productID = x.productId, Review = x.review });
            foreach (var item in result4)
            {
                Console.WriteLine("Product id is " + item.productID + " Review is " + item.Review);
            }
            //uc6
            var result5 = products.Skip(5);
            Display(result5.ToList());
        }
    }

  }
