using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_TEST_TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {


            SELECT Products.Name, Categories.Name
            FROM Products
            LEFT JOIN ProductCategories ON Products.Id = ProductCategories.ProductId
            LEFT JOIN Categories ON ProductCategories.CategoryId = Categories.Id
        }
    }
}
