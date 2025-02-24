using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 05 Zip Operator - Deferred Execution - [ Zip() ]
            //Produces a sequence with elements that came from zipping two or Three sequences.
            //The length of the produced sequence is like the shortest length of one of the source sequences.

            #region Zip<T1,T2>(IEnumerable<T2> second)
            //Returns a sequence of tuples ( T1Element, T2Element ) with elements from the two specified sequences

            //string[] names = ["Omar", "Amr", "Ahmd", "May", "Aya"];
            //int[] Numbers = Enumerable.Range(1, 10).ToArray();
            //char[] chars = ['A', 'B', 'C', 'D', 'E'];

            //var result = names.Zip(;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //// (Omar, 1)
            //// (Amr, 2)
            //// (Ahmd, 3)
            //// (May, 4)
            //// (Aya, 5) 

            #endregion

            #region Zip<T1,T2>(IEnumerable<T2> second, Func<T1,T2,TResult> resultSelector)
            ////Returns a sequence of Specific format not in tuples with elements from the two specified sequences

            //string[] names = ["Omar", "Amr", "Ahmd", "May", "Aya"];
            //int[] Numbers = Enumerable.Range(1, 10).ToArray();
            //char[] chars = ['A', 'B', 'C', 'D', 'E'];

            //var result = names.Zip(Numbers,(Name,Num) => new { Index = Num, Name = Name});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //// { Index = 1, Name = Omar }
            //// { Index = 2, Name = Amr }
            //// { Index = 3, Name = Ahmd }
            //// { Index = 4, Name = May }
            //// { Index = 5, Name = Aya }

            #endregion

            #region Zip<T1,T2,T3>(IEnumerable<T2> second, IEnumerable<T3> third)
            ////Returns a sequence tuples ( T1Element, T2Element ) with elements from the "Three" specified sequences

            //string[] names = ["Omar", "Amr", "Ahmd", "May", "Aya"];
            //int[] Numbers = Enumerable.Range(1, 10).ToArray();
            //char[] chars = ['A', 'B', 'C', 'D', 'E'];

            //var result = names.Zip(Numbers,chars);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //// (Omar, 1, A)
            //// (Amr, 2, B)
            //// (Ahmd, 3, C)
            //// (May, 4, D)
            //// (Aya, 5, E)

            #endregion

            #endregion

            #region Part 06 Grouping Operators - Deferred Execution - GroupBy<TSource,TKey>(Func<TSource,TKey> keySelector)
            //Group The Elements of a sequence according to a specific key selector function
            //Returns an IEnumerable<IGrouping<TKey,TSource>>, where is each IGrouping<TKey,TSource> is object contains
            //a sequence of objects and a key.

            #region Example01 - Get Products Grouped by Category

            #region 01 - Fluent Syntax

            //var result = ProductsList.GroupBy<Product,string>(p => p.Category);

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category.Key);
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"         {product}");
            //    }
            //}

            #endregion

            #region 02 - Query Syntax

            //var result= from product in ProductsList
            //            group product by product.Category;//Query syntax can end with group by.

            ///// result is of type => IEnumerable<IGrouping<string,Product>>? result.
            /////result is collection that contain elements, every element is group that has "string" represent type of name of category
            /////and "Product" represent the type of each product in the category group.
            /////foreach (var item in result)
            /////{
            /////    Console.WriteLine(item);//Unhandled exception. System.TypeInitializationException: The type initializer for 'Demo.ListGenerator' threw an exception.
            /////} 
            /////item is not flat object that can i print it direct
            /////it contain elements represent groups, every group has key "name of the group" and other elements inisde it. 

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category.Key);//Name of category
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"           {product}");
            //    }

            //}

            #endregion

            #endregion

            #region Example02 - Get Products "In Stock" Grouped by Category

            #region 01 - Fluent Syntax

            //var result = ProductsList.Where(p => p.UnitsInStock > 0)
            //                         .GroupBy(p => p.Category);

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category.Key);
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"          {product}");
            //    }
            //}

            #endregion

            #region 02 - Query Syntax

            //var result = from product in ProductsList
            //             where product.UnitsInStock > 0
            //             group product by product.Category;

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category.Key);
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"         {product}");
            //    }
            //}

            #endregion

            #endregion

            #region Example03 - Get Products in stock Grouped by category that contains more than 10 product.

            #region 01 - Fluent Syntax

            //var result = ProductsList.Where(p => p.UnitsInStock > 0)
            //                         .GroupBy(p => p.Category)
            //                         .Where(c => c.Count() > 10);
            //foreach (var category in result)
            //{
            //    Console.WriteLine(category.Key);
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"         {product}");
            //    }
            //}

            #endregion

            #region 02 - Query Syntax

            //var result = from p in ProductsList
            //             where p.UnitsInStock > 0
            //             group p by p.Category
            //               into categories
            //             where categories.Count() > 10
            //             select categories;

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category.Key);
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"         {product}");
            //    }
            //} 

            #endregion

            #endregion

            #region Example04 - Get Category name of products in stock that contains more than 10 product and number of product in each category

            #region 01 - Fluent Syntax

            //var result = ProductsList.Where(p => p.UnitsInStock > 0)
            //                         .GroupBy(p => p.Category)
            //                         .Where(c => c.Count()>10)
            //                         .Select(c => new
            //                         {
            //                             CategoryName = c.Key,
            //                             NumOfProducts = c.Count()
            //                         });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 02 - Query Syntax

            //var result = from p in ProductsList
            //             where p.UnitsInStock > 0
            //             group p by p.Category
            //             into category
            //             where category.Count() > 10
            //             select new
            //             {
            //                 Category = category.Key,
            //                 NumOfProducts = category.Count()
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #endregion

        }
    }
}
