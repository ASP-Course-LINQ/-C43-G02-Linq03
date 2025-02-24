using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 - Partitioning Operators

            #region P01|Q01 - Get the first 3 orders from customers in Washington


            #endregion

            #region P01|Q02 - Get all but the first 2 orders from customers in Washington.


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
        }
    }
}
