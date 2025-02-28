using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using static Assignment.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01 - Partitioning Operators

            #region P01|Q01 - Get the first 3 orders from customers in Washington

            #region 01 - FluentSyntax

            //var result = CustomersList.Where(C => C.Region == "WA").Select(C => new
            //{
            //    C.CustomerName,
            //    First3Orders = C.Orders.Take(3)
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CustomerName);
            //    foreach (var orders in item.First3Orders)
            //    {
            //        Console.WriteLine(orders);
            //    }
            //} 

            #endregion

            #region 02 - QuerySyntax

            //var result = from customer in CustomersList
            //             where customer.Region == "WA"
            //             select new
            //             {
            //                 customer.CustomerName,
            //                 First3Orders = customer.Orders.Take(3)
            //             };

            //foreach (var customer in result)
            //{
            //    Console.WriteLine(customer.CustomerName);
            //    foreach (var order in customer.First3Orders)
            //    {
            //        Console.WriteLine(order);
            //    }
            //}

            #endregion

            #endregion

            #region P01|Q02 - Get all but the first 2 orders from customers in Washington.

            #region 01 - FluentSyntax

            //var result = CustomersList.Where(C => C.Region == "WA").Select(C => new
            //{
            //    C.CustomerName,
            //    OrdersExceptFirst2 = C.Orders.Skip(2)
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CustomerName);
            //    foreach (var orders in item.OrdersExceptFirst2)
            //    {
            //        Console.WriteLine(orders);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 02 - QuerySyntax

            //var result = from customer in CustomersList
            //             where customer.Region == "WA"
            //             select new
            //             {
            //                 customer.CustomerName,
            //                 OrdersExceptFirst2 = customer.Orders.Skip(2)
            //             };

            //foreach (var customer in result)
            //{
            //    Console.WriteLine(customer.CustomerName);
            //    foreach (var order in customer.OrdersExceptFirst2)
            //    {
            //        Console.WriteLine(order);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #endregion

            #region P01|Q03 -  Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((num, index) => num > index);

            //Console.WriteLine(string.Join(", ",result));//5, 4

            #endregion

            #region P01|Q04 - Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(num => num % 3 != 0);

            //Console.WriteLine(string.Join(", ",result));//3, 9, 8, 6, 7, 2, 0

            #endregion

            #region P01|Q05 - Get the elements of the array starting from the first element less than its position.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((num, index) => num >index);

            //Console.WriteLine(string.Join(", ",result));//1, 3, 9, 8, 6, 7, 2, 0

            #endregion

            #endregion

            #region Part02 - Grouping Operators

            #region P02|Q01 - Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(num => num % 5);

            //foreach (var remainder in result)
            //{
            //    Console.WriteLine($"Numbers With remainder of {remainder.Key} when divided by 5: ");
            //    foreach (var num in remainder)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            #endregion

            #region P02|Q02 - Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input

            //string[] txtFile = File.ReadAllLines("dictionary_english.txt");

            //var result = txtFile.GroupBy(t => t.ElementAt(0));

            //foreach (var firstChar in result)
            //{
            //    Console.WriteLine($"\nWords That Has char '{firstChar.Key}' As First Char:");
            //    foreach (var word in firstChar)
            //    {
            //        Console.WriteLine($"  {word}");
            //    }
            //}

            #endregion

            #region P02|Q03 - Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var result = Arr.GroupBy(w => w, new StringComparer());

            //foreach (var item01 in result)
            //{
            //    foreach (var item02 in item01)
            //    {
            //        Console.WriteLine(item02);
            //    }
            //    Console.WriteLine("....");
            //}

            #endregion

            #endregion

        }
    }
}
