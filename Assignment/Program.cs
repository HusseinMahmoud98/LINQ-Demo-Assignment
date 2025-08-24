using static Assignment.ListGenerator;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

        }
    }
}
