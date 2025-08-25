using static Task.ListGenerator;
namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            ////Return Numbers whose position is match their value int[]
            //int[] Arr = { 3, 4, 2, 0, 1, 5, 6 };

            //var result = Arr.Where((number, index) => number == index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item); //2, 5, 6 
            #endregion

            #region Q02
            ////Produce a sequence containing some properties of products, including unitprice
            ////which is renamed to price in the result
            //var result = ProductList.Select(
            //    p => new
            //    {
            //        p.ProductID,
            //        p.ProductName,
            //        Price = p.UnitPrice
            //    });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q03
            ////Select all orders where the order was made in 1998 or later
            //var result = CustomerList.SelectMany(o => o.Orders).Where(o => o.OrderDate >= DateTime.Parse("1998-1-1"));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q04
            ////Name of the product with the highest unit price (make it with at least 2 ways)
            //var result = ProductList.OrderByDescending(p => p.UnitPrice).Select(p => p.ProductName).Take(1);
            //Console.WriteLine(result.ElementAt(0));

            //var max = ProductList.Max(p => p.UnitPrice);
            //var result2 = ProductList.Where(p => p.UnitPrice == max).FirstOrDefault();
            //Console.WriteLine(result2?.ProductName);

            #endregion

            //Find the unique category names from the product list -
            //do it in 2 ways: (1) using set operators, and (2) using casting operators

            var result = ProductList.Select(p => p.Category).Distinct();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------------------------");

            var result2 = ProductList.Select(p => p.Category).ToHashSet();
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
