using System.Collections;
using System.Data.Common;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text.RegularExpressions;
using static Demo.ListGenerator;

namespace Demo
{
    internal class Program
    {
        public dynamic fun()
        {
            return 0;
        }

        public void PrintList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            #region Session 01

            #region keywords [var - dynamic]
            //// Implicitly-Type Local vatiables [var - dynamice]
            ////var
            //var Data01 = "Husein";

            //// Data01 = 10; //Invalid


            //// dynamic : Like var in Java Script
            ////CLR will detect the datatype of the local variable base on the last variable at runtime

            //dynamic Data02 = "Hussein";
            //Console.WriteLine(Data02.GetType().Name);
            //Data02 = 10;
            //Data02 = 1.3;
            //Data02 = 1.3f;
            //Data02 = 7.3m;
            //Data02 = 'q';

            #endregion

            #region Anonymous Type
            //var E01 = new { Id = 1, Name = "Hussein", Salary = 15000 };
            ////var E02 = new { Id = 1, Name = "Hussein", Salary = 15000 };

            //var E02 = E01 with { Id = 2 };

            ////E01.Id = 12; //Invalid: Anonymous variables is immuteable type so you can't change it value after creation

            //Console.WriteLine(E01.GetType().Name); //<>f__AnonymousType0`3
            //Console.WriteLine(E02.GetType().Name); //<>f__AnonymousType0`3


            //Console.WriteLine(E01.ToString()); //{ Id = 1, Name = Hussein, Salary = 15000 }
            //Console.WriteLine(E02.ToString()); //{ Id = 2, Name = Hussein, Salary = 15000 }

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());

            //if (E01.Equals(E02)) //Compiler will override on equals and GetHashCode()
            //    Console.WriteLine("E01 == E02");

            //else
            //    Console.WriteLine("E01 != E02"); 
            #endregion

            #region Extension Methods
            //int number = 1234;
            //var reversedNumber =number.Reverse();
            //Console.WriteLine(reversedNumber); 
            #endregion

            #region LINQ Introduction
            ////LINQ: Language Integrated Query
            //List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            ////Input Sequence -> LINQ Operator -> Output Sequence
            //var result1 = Enumerable.Where(numbers, N => N % 2 == 0 );

            ////Input Sequence -> LINQ Operator -> Output Value
            //var result2 = Enumerable.Any(numbers, N => N % 2 == 0);

            ////No Input -> LINQ Operator -> Output Sequence
            //var result3 = Enumerable.Range(1, 3);

            //foreach (var item in result1)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            //Console.WriteLine(result2); //True

            //foreach (var item in result3)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine(); 
            #endregion

            #region LINQ Syntax
            ////1. Fluent Syntax
            //// Use LINQ Method
            ////1.1 LINQ Operator as => Class Member method through class "Enumberable"
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result1 = Enumerable.Where(numbers, x => x % 2 == 0);

            //foreach (var item in result1)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            ////1.2 LINQ Operator as => Extension Method Through Sequence [Recommended]
            //var result2 = numbers.Where(x => x % 2 == 0);

            //foreach (var item in result2)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            ////---------------------------------------------------
            ////2. Query Syntax [Query Experssion] Like SQL Style
            //var result3 = from N in numbers
            //             where N%2 == 0
            //             select N;

            //foreach (var item in result3)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine(); 
            #endregion

            #region LINQ Execution Ways
            //// LINQ Execution Ways -> Total 13 Category
            //// 1. Differed Execution Way -> 10 Category
            //// 2. Immediate Execution Way  -> 3 Category [Element Operator, Casting Operator, Aggregate Operator]


            //// 1. Differed Execution Way
            //List<int> Numbers1 = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            //var result1 = Numbers1.Where(x => x %2 == 0); //Differed

            //Numbers1.AddRange(new int[]{ 11,12, 13, 14, 15});

            //foreach (var item in result1)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();

            ////2. Immediate Execution Way
            //List<int> Numbers2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result2 = Numbers2.Where(x => x % 2 == 0).ToList(); //Immediate

            //Numbers2.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (var item in result2)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            #endregion

            #region Setup Data
            ////Console.WriteLine(ListGenerator.ProductList[0]);
            ////Console.WriteLine(ListGenerator.CustomerList[0]);

            //var result1 =  ListGenerator.ProductList.Where(P => P.UnitsInStock == 0);
            //var result2 = ListGenerator.CustomerList.Where(c => c.City == "Berlin");

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #endregion


            #region 1. Filteration Operation [Where/OfType]
            //LINQ: 40+ Extension Method
            //LINQ: 13 Categories

            // 1. Filteration Operators - Where/OfType
            //Fluent Syntax
            //var result = ProductList.Where(p => p.UnitsInStock == 0);

            //Query method
            //var result = from P in ProductList
            //             where P.UnitsInStock == 0
            //             select P;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = ProductList.Where(p => p.Category == "Meat/Poultry");
            //var result = from p in ProductList
            //             where p.Category == "Meat/Poultry"
            //             select p;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //var result = ProductList
            //    .Where(p => p.UnitsInStock > 0)
            //    .Where(c => c.Category == "Meat/Poultry");

            //var result = from p in ProductList
            //             where p.UnitsInStock > 0 && p.Category == "Meat/Poultry"
            //             select p;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            ////Note: Indexed Where is Valid Only in fluent syntax
            //var result = ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList arrayList = new ArrayList() { 1,2,3, "Hussein", 1.3f, 1.1, 5.4m, ProductList[0] };
            //var result = arrayList.OfType < string>();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 2. Transfortmation Operator - Select / SelectMany
            ////2. Transfortmation Operator - Select / SelectMany
            ////Fluent Syntax
            //var result = ProductList.Select(p => p.ProductName);

            ////Query Syntax
            //var result = from p in ProductList
            //             select p.ProductName;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////Fluent Syntax
            //var result = ProductList
            //    .Where(p => p.UnitsInStock > 0 && p.Category == "Seafood")
            //    .Select(
            //        p =>new {Name = p.ProductName,
            //        p.Category,
            //        OldPrice = p.UnitPrice,
            //        NewPrice = p.UnitPrice - p.UnitPrice*0.9m}
            //        );

            ////Query Syntax
            //var result = from p in ProductList
            //             where p.UnitsInStock > 0 && p.Category == "Seafood"
            //             select new
            //             {
            //                 p.ProductName,
            //                 p.Category,
            //                 OldPrice = p.UnitPrice,
            //                 NewPrice = p.UnitPrice - p.UnitPrice * 0.1m
            //             }; 

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = CustomerList.SelectMany(c => c.Orders);

            //var result = from c in CustomerList
            //             from o in c.Orders
            //             select o;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////Note: Indexed Select valid only in fluent syntax only
            //var result = ProductList.Select((P, Index) => new { Index, P.ProductName})
            //    .Where(P => P.Index < 5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 3. Ordering Operators
            //3. Ordering Operators
            //var result = ProductList.OrderBy(p => p.UnitPrice)
            //                        .Select(p => new 
            //                        {
            //                            p.ProductName, 
            //                            p.UnitPrice, 
            //                            p.UnitsInStock
            //                        });


            //var result = ProductList.OrderByDescending(p => p.UnitsInStock)
            //                       .ThenBy(p => p.UnitPrice) //Ascending
            //                       .Select(p => new
            //                       {
            //                           p.ProductName,
            //                           p.UnitPrice,
            //                           p.UnitsInStock
            //                       });

            //var result = ProductList.Where(p => p.Category == "Seafood" && p.UnitsInStock > 0)
            //                        .OrderByDescending(p => p.UnitsInStock)
            //                        .ThenBy(p => p.UnitPrice) //Ascending
            //                        .Select(p => new
            //                        {
            //                            p.ProductName,
            //                            p.UnitPrice,
            //                            p.UnitsInStock
            //                        });

            //var result = from p in ProductList
            //             orderby p.UnitPrice descending
            //             select p;

            //var result = from p in ProductList
            //             where p.Category == "Meat/Poultry" && p.UnitsInStock > 0
            //             orderby p.UnitPrice descending, p.UnitsInStock ascending //Desalut is ascending
            //             select new 
            //             {
            //                p.ProductName,
            //                p.UnitPrice,
            //                p.UnitsInStock
            //             };

            //var result = ProductList.Reverse<Product>();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Elements Operatorss - Immediate Execution
            // 4. Elements Operatorss - Immediate Execution


            //var result = ProductList.First(); //may throw exception if the sequence contains no elements
            //result = ProductList.Last(); //may throw exception if the sequence contains no elements
            //result = ProductList.First(p => p.UnitsInStock == 0);  //may throw exception if the sequence contains no elements

            //ProductList = new List<Product>();
            //result = ProductList.FirstOrDefault();
            //result = ProductList.FirstOrDefault(new Product { ProductName = "Default Product"});
            //result = ProductList.FirstOrDefault(p => p.UnitsInStock == 1000, new Product { ProductName = "Default Product", });


            //Console.WriteLine(result?.ProductName?? "NA");


            ////////////////////////////////////////////////////////////////////////////////////////
            //result = ProductList.ElementAt(0); //May throw exception
            //result = ProductList.ElementAtOrDefault(0);


            ////////////////////////////////////////////////////////////////////////////////////////
            //result = ProductList.Single(); //May throw exception
            //result = ProductList.Where(p=>p.ProductID == 1).Single(); //May throw exception
            //result = ProductList.Single(p => p.ProductID == 1);
            //result = ProductList.SingleOrDefault();
            //result = ProductList.SingleOrDefault( new Product() { ProductName = "Default Value"});
            //result = ProductList.SingleOrDefault(p => p.ProductID == 1 ,new Product() { ProductName = "Default Value" });

            ////////////////////////////////////////////////////////////////////////////////////////
            // ProductList = new List<Product>();

            //var result = ProductList.DefaultIfEmpty(new Product() { ProductName = "Default Name" });


            //result = ProductList.DefaultIfEmpty();


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 5. Aggregate Operators - Immediate Execution
            // 5. Aggregate Operators - Immediate Execution
            //var result = ProductList.Count();
            //result = ProductList.Count(P => P.UnitsInStock == 0);
            //result = ProductList.Where(P => P.UnitsInStock == 0).Count();

            //var result = ProductList.Sum(P => P.UnitPrice);

            //result = ProductList.Average(P => P.UnitPrice);

            //var result = ProductList.Max();
            //var result = ProductList.Max(new ProductsComparerUnitsInStock());

            //var result = ProductList.MaxBy(p => p.UnitPrice);
            //var result = ProductList.MaxBy( P => P  , new ProductsComparerUnitsInStock());

            //Console.WriteLine(result);


            /////////////////////////////////////////////////////////////////////////////////////////
            //List<string> Names = new List<string>() { "Hussein", "Mahmoud", "Fouad", "ElSaid" };

            //var result = Names.Aggregate((s01, s02) => $"{s01} {s02}");

            //Console.WriteLine(result); 
            #endregion

            #region 6. Casting Operators --Immediate Execution
            ////6. Casting Operators --Immediate Execution
            ////List<Product> list = ProductList.Where(p => p.UnitsInStock == 0).ToList();
            ////Dictionary<long, Product> list = ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(P => P.ProductID, P => P);
            //HashSet<Product> list = ProductList.Where(p => p.UnitsInStock == 0).ToHashSet();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 7. Gneration Operators
            ////7. Gneration Operators
            ////Can only be called as -> Class Mmmber Method Through "Enumerable" Class

            //// Range, Empty, Repeat

            ////var result = Enumerable.Range(1, 100);
            ////var result = Enumerable.Empty<Product>();

            //var result = Enumerable.Repeat(ProductList[0], 3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 8. Set Operators - Union Family
            //// 8. Set Operators - Union Family
            //// Union - Union All - Intersect - Except

            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            //var result = Seq01.Union(Seq02);
            //result = Seq01.Concat(Seq02);
            //result = result.Distinct();
            //result = Seq01.Except(Seq02);
            //result = Seq01.Intersect(Seq02);

            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //} 
            #endregion

            #region  9. Quantifier Operators - Resturns Boolean
            //// 9. Quantifier Operators - Resturns Boolean
            //// Any - All - SequenceEqual - Contains

            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            //var result = Seq01.Any();
            //result = Seq01.Any(N => N % 2 == 0);
            //result = ProductList.Any(P => P.UnitsInStock == 0);

            //result = ProductList.All(P => P.UnitsInStock == 0);

            ////ProductList = new List<Product>();
            //result = ProductList.All(p=> p.UnitsInStock == 0); //true becausr the list is empty
            //result = ProductList.All(p =>  p.UnitPrice > 0);

            //result = Seq01.SequenceEqual(Seq02); //False

            //result = Seq02.Contains(77);


            //Console.WriteLine(result); 
            #endregion

            #region 10. Zipping Operator
            //// 10. Zipping Operator
            //// Zip

            //List<string> Words = new List<string>() { "Ten", "Tweenty", "Thirty", "Fourty"};
            //List<int> Numbers = new List<int>() { 10, 20, 30, 40, 50, 60 };

            //var result = Words.Zip(Numbers, (W, N) => $"{W} --> {N}");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 11. Grouping Operators
            //// 11. Grouping Operators

            ////var result = ProductList.GroupBy(p => p.Category);

            ////result = from p in ProductList
            ////         group p by p.Category;

            ////foreach (var category in result)
            ////{
            ////    Console.WriteLine(category.Key);

            ////    foreach (var product in category)
            ////    {
            ////        Console.WriteLine($"......{product}");
            ////    }

            ////    Console.WriteLine("-------------------------------------------------------------------");
            ////}

            ////-----------------------------------------------------------------------------------------------

            ////var Result = from p in ProductList
            ////             where p.UnitsInStock > 0
            ////             group p by p.Category
            ////             into Category
            ////             where Category.Count() > 1
            ////             select new { CategoryName = Category.Key, CountOfCategory = Category.Count() };

            ////var Result = ProductList.Where(p => p.UnitsInStock > 0)
            ////            .GroupBy(p => p.Category)
            ////            .Where(c => c.Count() > 0)
            ////            .Select(c => new { CategoryName = c.Key, Count = c.Count() });

            //var Result = ProductList.Where(p => p.UnitsInStock > 0)
            //            .GroupBy(p => p.Category)
            //            .OrderByDescending(p => p.Count())
            //            .Where(c => c.Count() > 0)
            //            .Select(c => new { CategoryName = c.Key, Count = c.Count() });


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region  12. Partioning Operators - Take, TakeLast, Skip, SkipLast, TakeWhile, SkipWhile
            //// Partioning Operators - Take, TakeLast, Skip, SkipLast, TakeWhile, SkipWhile
            //var result = ProductList.Take(5);
            //result = ProductList.Where(p => p.UnitsInStock == 0).Take(2);
            //result = ProductList.Where(p => p.UnitsInStock == 0).TakeLast(4);

            //result = ProductList.Skip(10);
            //result = ProductList.Where(p => p.UnitsInStock == 0).SkipLast(2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] Numbers = { 3, 6, 7, 1, 0, 1, 9 };

            //var result = Numbers.TakeWhile(n => n % 3 == 0);
            //result = Numbers.SkipWhile(n => n% 3 == 0);

            //int[] Numbers2 = { 5, 4, 1, 3, 9, 6, 7, 2, 0 };
            //result = Numbers2.TakeWhile((n, Index) => n > Index);
            //result = Numbers2.SkipWhile((n, Index) => n > Index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region let - into
            List<string> Names = new List<string>() { "Ahmed", "Ali", "Mohamed", "Mona", "Aya", "Mariam",
                                                     "Tuqqa", "Sally", "Mahmoud", "Osama"};

            //var result = Regex.Replace("Hussein", "[aeoiuAEOUI]", string.Empty);
            //Console.WriteLine(result); //Hssn

            //var result2 = from name in Names
            //             select Regex.Replace(name, "[aeoiuAEOUI]", string.Empty);

            // var result2 = from name in Names
            //             select Regex.Replace(name, "[aeoiuAEOUI]", string.Empty);

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            //var result3 = from name in Names
            //              select Regex.Replace(name, "[aeouiAEOUI]", string.Empty)
            //              into NoVolNames
            //              where NoVolNames.Length > 3
            //              select NoVolNames;

            //foreach (var item in result3)
            //{
            //    Console.WriteLine(item);
            //}

            //var result4 = from name in Names
            //              let NoVolNames = Regex.Replace(name, "[aeouiAEOUI]", string.Empty)
            //              where NoVolNames.Length > 3
            //              select NoVolNames;


            //foreach (var item in result4)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

        }
    }
}
