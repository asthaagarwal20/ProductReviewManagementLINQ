using System;
using System.Collections.Generic;
using System.Data;
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
        public static void DisplayTable(DataTable product)
        {
            foreach (DataRow row in product.Rows)
            {
                Console.WriteLine("Product id is "+row["ProductID"]+" Rating is "+row["Rating"]);
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

            //uc8
            DataTable productDataTable = new DataTable();
            productDataTable.Columns.Add("ProductID", typeof(int));
            productDataTable.Columns.Add("UserID",typeof(int));
            productDataTable.Columns.Add("Rating",typeof (int));
            productDataTable.Columns.Add("Review");
            productDataTable.Columns.Add("IsLike", typeof(bool));
            productDataTable.Rows.Add(1, 12, 5, "good", "true");
            productDataTable.Rows.Add(2, 15, 2, "good", "true");
            productDataTable.Rows.Add(3, 56, 4, "good", "true");
            productDataTable.Rows.Add(4, 34, 1, "bad", "false");
            productDataTable.Rows.Add(5, 12, 5, "good", "true");
            productDataTable.Rows.Add(6, 15, 2, "good", "true");
            productDataTable.Rows.Add(7, 56, 4, "good", "true");
            productDataTable.Rows.Add(8, 34, 1, "bad", "false");
            productDataTable.Rows.Add(9, 12, 5, "good", "true");
            productDataTable.Rows.Add(10, 15, 2, "good", "true");
            productDataTable.Rows.Add(11, 56, 4, "good", "true");
            productDataTable.Rows.Add(12, 34, 1, "bad", "false");
            productDataTable.Rows.Add(13, 12, 5, "good", "true");
            productDataTable.Rows.Add(14, 15, 2, "good", "true");
            productDataTable.Rows.Add(15, 56, 4, "good", "true");
            productDataTable.Rows.Add(16, 34, 1, "bad", "false");
            DisplayTable(productDataTable);
        }
    }

  }
