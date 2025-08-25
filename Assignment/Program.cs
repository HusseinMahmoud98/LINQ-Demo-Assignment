using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using static Assignment.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            ////Query Syntax
            //var result2 = from p in ProductList
            //              orderby p.Category, p.UnitPrice descending
            //              select p;

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q05
            //5.Sort first by-word length and then by a case -insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(word => word.Length).ThenByDescending(word => word.ToUpper());

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result2 = from arr in Arr
            //              orderby arr.Length, arr.ToUpper() descending
            //              select arr;

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q06
            ////6. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where(d => d[1] == 'i').Reverse().ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #endregion


            #region LINQ – Transformation Operators
            //LINQ – Transformation Operators

            #region Q01
            ////1. Return a sequence of just the names of a list of products.
            //var result = ProductList.Select(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result2 = from p in ProductList
            //              select p.ProductName;

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q02
            ////2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var resultUpperCase = words.Select(word => word.ToUpper());

            //var resultLowerCase = words.Select(word => word.ToLower());

            //Console.WriteLine("Upper case version");
            //Console.WriteLine("------------------");
            //foreach (var item in resultUpperCase)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("\n-------------------------------------------------------------");
            //Console.WriteLine("Lower case version");
            //Console.WriteLine("------------------");
            //foreach (var item in resultLowerCase)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q03
            //3. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //int[,] numbersAB = new int[2, 7];

            //for (int i = 0; i < numbersA.Length; i++)
            //{
            //    numbersAB[0,i] = numbersA[i];
            //}

            //for (int i = 0; i < numbersB.Length; i++)
            //{
            //    numbersAB[1, i] = numbersB[i];
            //}

            #endregion

            #region Q04
            ////4. Select all orders where the order total is less than 500.00.
            ////Fluent Syntax
            //var result = CustomerList.SelectMany(c => c.Orders).Where(o => o.Total < 500);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////Query Syntax
            //var result2 = from c in CustomerList
            //             from o in c.Orders
            //             where o.Total < 500
            //             select o;

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region LINQ - Set Operators  
            //LINQ - Set Operators

            #region Q01
            ////1.Find the unique Category names from Product List
            //var result = ProductList.Select(p => p.Category).Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q02
            ////2.Produce a Sequence containing the unique first letter from both product and customer names.
            //var result = ProductList.DistinctBy(p => p.ProductName[0]).Select(p => p.ProductName)
            //    .Union(CustomerList.DistinctBy(c => c.CustomerName[0]).Select(c => c.CustomerName));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q03
            //3. Create one sequence that contains the common first letter from both product and customer names.
            var result = ProductList.IntersectBy(CustomerList.Select(c => c.CustomerName[0]), p => p.ProductName[0])
                                    .Select(p => p.ProductName[0]);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            } 
            #endregion

            #endregion

        }
    }
}
