using System.Runtime.Intrinsics.Arm;
using System.Threading;
using System.Xml.Linq;
using static Assignment.ListGenerator;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Restriction Operators
            // LINQ - Restriction Operators
            #region Q01
            //1. Find all products that are out of stock.
            #region Fluent Syntax
            //Fluent Syntax
            //var result = ProductList.Where(p => p.UnitsInStock == 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Query Syntax
            //var result2 = from p in ProductList
            //              where p.UnitsInStock == 0
            //              select p;

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #endregion

            //2. Find all products that are in stock and cost more than 3.00 per unit.
            //Fluent Syntax
            //var result = ProductList.Where(p => p.UnitPrice > 3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Query Syntax
            //var result2 = from p in ProductList
            //              where p.UnitPrice > 3
            //              select p;

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region LINQ - Element Operators
            //LINQ - Element Operators
            #region Q01
            ////1. Get first Product out of Stock 
            ////Fluent Syntax
            //var result = ProductList.Where(p=> p.UnitsInStock == 0).ElementAtOrDefault(0);  // will not throw exception
            //Console.WriteLine(result);

            ////or
            //var result2 = ProductList.Where(p => p.UnitsInStock == 0).FirstOrDefault();  // will not throw exception
            //Console.WriteLine(result2);


            ////or
            //var result3 = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);  // will not throw exception
            //Console.WriteLine(result3);

            #endregion

            #region Q02
            ////2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductList.Where(p => p.UnitPrice > 1000).ElementAtOrDefault(0);
            //Console.WriteLine(result);

            ////or
            //var result2 = ProductList.Where(p => p.UnitPrice > 1000).FirstOrDefault();
            //Console.WriteLine(result2);

            ////or
            //var result3 = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result3);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            //LINQ - Aggregate Operators
            #region Q01
            ////1. Uses Count to get the number of odd numbers in the array
            ////Int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Count(n => n % 2 == 1);
            //Console.WriteLine(result); 
            #endregion

            #region Q02
            ////2. Get the total of the numbers in an array.
            ////Int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count();
            //Console.WriteLine(result); //10 
            #endregion

            #region Q03
            ////REVIEW THIS
            ////3. Get the total number of characters of all words in dictionary_english.txt
            ////   (Read dictionary_english.txt into Array of String First).
            //string words = "dictionary_english.txt";
            //string[] arrString = words.Split('_', '.'); // {"dictionary", "english", "txt"}

            //var result = arrString.Sum(c => c.Length);

            //Console.WriteLine(result); 
            #endregion

            #region Q04
            ////4. Get the length of the shortest word in dictionary_english.txt
            ////   (Read dictionary_english.txt into Array of String First).
            //string word = "dictionary_english.txt";
            //string[] arrString = word.Split(' ', '.'); // {"dictionary", "english", "txt"}

            //var result = arrString.Min(w => w.Length);
            //Console.WriteLine(result); //3


            #endregion

            #region Q05  //To be continued
            //REVIEW THIS
            //5. Get the total units in stock for each product category.
            #endregion

            #endregion #endregion

            #region LINQ - Ordering Operators
            #region Q01
            ////1. Sort a list of products by name 
            //Fluent Syntax
            //var result = ProductList.OrderBy(p => p.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////Query Syntax
            //var result2 = from p in ProductList
            //              orderby (p.ProductName)
            //              select p;

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q02
            //2. Sort a list of products by units in stock from highest to lowest.
            //Fluent Syntax
            //var result = ProductList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////Query Syntax
            //var result2 = from p in ProductList
            //              orderby p.UnitsInStock descending
            //              select p;

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q03
            //3. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //Fluent Syntax
            //var result = Arr.OrderBy(d => d.Length).ThenBy(p=>p);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////Query Syntax
            //var result2 = from arr in Arr
            //              orderby arr.Length, arr
            //              select arr;

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q04
            ////4. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            ////Fluent Syntax
            //var result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Query Syntax
            var result2 = from p in ProductList
                          orderby p.Category, p.UnitPrice descending
                          select p;

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            #endregion


            #endregion
        }
    }
}
