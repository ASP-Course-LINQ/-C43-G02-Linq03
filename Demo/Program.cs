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

            #region Part 07 Partitioning Operators - Deferred Execution [Take() - Skip() - TakeLast() - SkipLast() - TakeWhile() - SkipWhile()]

            #region 01 - Take<T>(int count)
            ////Returns a specified number of contiguous elements from the "start" of the sequence.
            ////Returns sequence of type IEnumerable<T> that contains the specified number of elements from the "start" of the sequence.

            //var result = ProductsList.Take(5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// ProductID:1,ProductName:Chai,Category:Beverages,UnitPrice:$18.00,UnitsInStock:100
            //// ProductID:2,ProductName:Chang,Category:Beverages,UnitPrice:$19.00,UnitsInStock:17
            //// ProductID:3,ProductName:Aniseed Syrup,Category:Condiments,UnitPrice:$10.00,UnitsInStock:13
            //// ProductID:4,ProductName:Chef Anton's Cajun Seasoning,Category:Condiments,UnitPrice:$22.00,UnitsInStock:53
            //// ProductID:5,ProductName:Chef Anton's Gumbo Mix,Category:Condiments,UnitPrice:$21.35,UnitsInStock:0

            #endregion

            #region 02 - TakeLast<T>(int count)
            ////Returns a specified number of contiguous elements from the "Last" of the sequence.
            ////Returns sequence of type IEnumerable<T> that contains the specified number of elements from the "Last" of the sequence.
            ////Returns a new enumerable collection that contains the last count elements from source sequence.

            //var result = ProductsList.TakeLast(5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// ProductID:73,ProductName:Röd Kaviar,Category:Seafood,UnitPrice:$15.00,UnitsInStock:101
            //// ProductID:74,ProductName:Longlife Tofu,Category:Produce,UnitPrice:$10.00,UnitsInStock:4
            //// ProductID:75,ProductName:Rhönbräu Klosterbier,Category:Beverages,UnitPrice:$7.75,UnitsInStock:125
            //// ProductID:76,ProductName:Lakkalikööri,Category:Beverages,UnitPrice:$18.00,UnitsInStock:57
            //// ProductID:77,ProductName:Original Frankfurter grüne Soße,Category:Condiments,UnitPrice:$13.00,UnitsInStock:32

            #endregion

            #region 03 - Skip<T>(int count)
            ////Bypasses/Skip a specified number of elements in a sequence and then returns the remaining elements after skip.
            ////Return an IEnumerable<T> that contains the elements that occur after the specified index in the input sequence
            ////Skipping is done from the "start" of the source sequence.

            //var result = ProductsList.Skip(5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 04 - SkipLast<T>(int count)
            ////Bypasses/Skip a specified number of elements in a sequence and then returns the remaining elements after skip.
            ////Return an IEnumerable<T> that contains the elements that occur after the specified index in the input sequence
            ////Skipping is done from the "End" of the source sequence.
            ////Returns a new enumerable collection that contains the elements from source - count elements from the end of the collection

            //var result = ProductsList.SkipLast(5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Example(Pagination) - Get the second 10 elements in productList

            //var result = ProductsList.Skip(10).Take(10);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 05 - TakeWhile

            #region 01 - TakeWhile<T>(Func<T,bool> predicate)
            ////Return Elements from a sequence as long as a specified condition is true
            ////once condition is false, stop and don't check rest of sequence elements.
            ////Return an IEnumerable<T> that contains the elements from the input sequence that occur 
            ////before (stop) - before the element at which the test/condition is false on it.

            //int[] numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2];

            //var result = numbers.TakeWhile(num => num > 1);

            //Console.WriteLine(string.Join(", ", result));// 5, 4 

            #endregion

            #region 02 - TakeWhile<T>(Func<T,int,bool> predicate)
            ////Return Elements from a sequence as long as a specified condition is true, the element's index is used in the logic of the predicate function
            ////once condition is false, stop and don't check rest of sequence elements.
            ////Return an IEnumerable<T> that contains the elements from the input sequence that occur 
            ////before (stop) - before the element at which the test/condition is false on it.

            //int[] numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2];

            //var result = numbers.TakeWhile((num, index) => num > index);//Take from the sequence the elements where it's value greater than it's index

            //Console.WriteLine(string.Join(", ", result));// 5, 4 

            #endregion

            #endregion

            #region 06 - SkipWhile

            #region 01 - SkipWhile<T>(Func<T,bool> predicate)
            ////Bypasses/Skip elements in a sequence as long as a specified condition is true and then return the remaining elements
            ////Returns an sequence of type IEnumerable<T> that contains the elements from the input sequence starting at
            ////the first element in the linear series that doesn't pass the predicate condition.

            //int[] numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2];

            //var result = numbers.SkipWhile(num => num > 1);

            //Console.WriteLine(string.Join(", ", result));// 1, 3, 9, 8, 6, 7, 2 

            #endregion

            #region 02 - SkipWhile<T>(Func<T,int,bool> predicate)
            ////Bypasses/Skip elements in a sequence as long as a specified condition is true and then return the remaining elements
            ////The Element's index is used in the logic of the predicate function
            ////Returns an sequence of type IEnumerable<T> that contains the elements from the input sequence starting at
            ////the first element in the linear series that doesn't pass the predicate condition.

            //int[] numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2];

            //var result = numbers.SkipWhile((num,index) => num > index);

            //Console.WriteLine(string.Join(", ", result));// 1, 3, 9, 8, 6, 7, 2 

            #endregion

            #endregion

            #endregion

        }
    }
}
