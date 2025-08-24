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

            ////LINQ - Element Operators
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

        }
    }
}
