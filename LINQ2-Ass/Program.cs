using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using System.Xml;

namespace LINQ2_Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***************************Assignment 02 LINQ********************************/

            /*Note: Use ListGenerators.cs & Customers.xml*/
            List<Product> products = ListGenerator.ProductList;
            #region LINQ - Element Operators

            #region Q1
            ////1.Get first Product out of Stock

            ////var outStock = products.FirstOrDefault(p => p.UnitsInStock == 0);
            ////Console.WriteLine($"first Product Name out of Stock => {outStock?.ProductName ?? "no data"}");
            #endregion

            #region Q2
            ////2.Return the first product whose Price > 1000, unless there is no match, 
            ////in which case null is returned.

            ////var price = products.FirstOrDefault(p => p.UnitPrice >1000);
            ////Console.WriteLine($"first Product whose Price > 1000 => {price??null}");
            #endregion

            #region Q3
            ////3.Retrieve the second number greater than 5
            ////Int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            ////int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ////int secNum=Arr.FirstOrDefault(n => n > 5 && n != Arr.FirstOrDefault(m => m > 5));
            ////Console.WriteLine($"second number greater than 5=> {secNum}");
            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region Q1
            ////1.Uses Count to get the number of odd numbers in the array
            ////Int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int count = Arr.Count(n => n % 2 != 0);
            //Console.WriteLine($"number of odd numbers=> {count}");
            #endregion

            #region Q2
            ////2.Return a list of customers and how many orders each has.

            //var customers = ListGenerator.CustomerList;
            //var result = customers.Select(c =>new { c.CustomerID,c.CustomerName,c.Address,OrdersCount= c.Orders.Count() });
            //Console.WriteLine("list of customers and how many orders each has");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q3
            ////3.Return a list of categories and how many products each has

            //var categories = products.GroupBy(c => c.Category).Select(x => new { cat = x.Select(c => c.Category).FirstOrDefault(), ProductsCount = x.Count() });
            //Console.WriteLine("list of categories and products Count");
            //foreach (var item in categories)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q4
            ////4.Get the total of the numbers in an array.
            ////Int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int Sum = Arr.Sum();
            //Console.WriteLine($"total of the numbers=> {Sum}");
            #endregion

            #region Q5
            ////5.Get the total number of characters of all words in dictionary_english.txt
            ////(Read dictionary_english.txt into Array of String First).


            #endregion

            #region Q6
            ////6.Get the length of the shortest word in dictionary_english.txt
            ////(Read dictionary_english.txt into Array of String First).

            #endregion

            #region Q7
            ////7.Get the length of the longest word in dictionary_english.txt
            ////(Read dictionary_english.txt into Array of String First).

            #endregion

            #region Q8
            ////8.Get the average length of the words in dictionary_english.txt
            ////(Read dictionary_english.txt into Array of String First).

            #endregion

            #region Q9
            ////9.Get the total units in stock for each product category.

            //var categories = products.GroupBy(c => c.Category).Select(x => new { cat = x.Select(c=>c.Category).FirstOrDefault(), TotalUnits = x.Sum(s=>s.UnitsInStock) });
            //Console.WriteLine("total units in stock for each product category");
            //foreach (var item in categories)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q10
            ////10.Get the cheapest price among each category's products

            //var categories = products.GroupBy(c => c.Category).Select(x => new { cat = x.Select(c => c.Category).FirstOrDefault(), CheapestPrice = x.OrderBy(s => s.UnitPrice).FirstOrDefault().UnitPrice });
            //Console.WriteLine("cheapest price among each category's products");
            //foreach (var item in categories)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q11
            ////11.Get the products with the cheapest price in each category(Use Let)


            #endregion

            #region Q12
            ////12.Get the most expensive price among each category's products.

            //var categories = products.GroupBy(c => c.Category).Select(x => new { cat = x.Select(c => c.Category).FirstOrDefault(), ExpensivePrice = x.OrderByDescending(s => s.UnitPrice).FirstOrDefault().UnitPrice });
            //Console.WriteLine("most expensive price among each category's products");
            //foreach (var item in categories)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q13

            ////13.Get the products with the most expensive price in each category.


            //var categories = products.GroupBy(c => c.Category).Select(x => new { cat = x.FirstOrDefault(), ExpensivePrice = x.OrderByDescending(s => s.UnitPrice).FirstOrDefault().UnitPrice });
            //Console.WriteLine("products with the most expensive price in each category");
            //foreach (var item in categories)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q14
            ////14.Get the average price of each category's products.

            //var categories = products.GroupBy(c => c.Category).Select(x => new { cat = x.Select(c => c.Category).FirstOrDefault(), AvgPrice = x.Average(s => s.UnitPrice) });
            //Console.WriteLine("total units in stock for each product category");
            //foreach (var item in categories)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region LINQ - Set Operators

            #region Q1
            ////1.Find the unique Category names from Product List

            var result = products.Select(p => p.Category.Distinct());
            Console.WriteLine("unique Category names from Product List");
            foreach (var product in products)
            {
                Console.WriteLine(product?.Category);
            }
            #endregion

            #region Q2
            ////2.Produce a Sequence containing the unique first letter from both product 
            ////and customer names.

            #endregion

            #region Q3
            ////3.Create one sequence that contains the common first letter from both product and customer names.

            #endregion

            #region Q4
            ////4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            #endregion

            #region Q5
            ////5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            #endregion
            #endregion

            #region LINQ - Partitioning Operators

            #region Q1
            ////1.Get the first 3 orders from customers in Washington

            #endregion

            #region Q2
            ////2.Get all but the first 2 orders from customers in Washington.

            #endregion

            #region Q3
            ////3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            ////int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            ////                4.Get the elements of the array starting from the first element divisible by 3.
            ////int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ////                5.Get the elements of the array starting from the first element less than its position.
            ////int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            #endregion

            #endregion

            #region LINQ - Quantifiers

            #region Q1
            ////1.Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            #endregion

            #region Q2
            ////2.Return a grouped a list of products only for categories that have at least one product that is out of stock.

            #endregion

            #region Q3
            ////3.Return a grouped a list of products only for categories that have all of 
            ////their products in stock.

            #endregion

            #endregion

            #region LINQ – Grouping Operators

            #region Q1
            ////Use group by to partition a list of numbers by their remainder when divided by 5
            ////List<int> numbers = new list<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            ////                    Output:

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbers.GroupBy(g => g % 5);
            //Console.WriteLine("list of numbers by their remainder when divided by 5");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}: ");
            //    foreach (var item2 in item)
            //    {
            //        Console.Write($"{item2} ,");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region
            ////Uses group by to partition a list of words by their first letter.
            ////Use dictionary_english.txt for Input

            #endregion

            #region Q3
            ////Consider this Array as an Input
            ////String[] Arr = { "from", "salt", "earn", " last", "near", "form"};
            ////Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            ////Output:


            #endregion


            #endregion

        }
    }
}
