namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 05 Zip Operator - Deferred Execution - [ Zip() ]
            //Produces a sequence with elements that came zipping two or more sequences
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

        }
    }
}
