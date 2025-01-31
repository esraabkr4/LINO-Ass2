namespace LINQ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ElementOperator
            List<int> list = new List<int>();
            List<int> emptyList = new List<int>();
            list.AddRange(new int[] { 1, 2, 3, 4, 5 });
            #region First & FirstOrDefualt
            int first=list.First();
            Console.WriteLine($"First Element {first}");

            var cond = list.First(n=>n>3);
            Console.WriteLine($"First Element With Condition {cond}");

            int firstOrDef = emptyList.FirstOrDefault();
            Console.WriteLine($"First or Default Element {firstOrDef}");
            #endregion
            #region Last & LastOrDefualt
            int last = list.Last();
            Console.WriteLine($"Last Element {last}");

            var lastCond = list.Last(n => n > 3);
            Console.WriteLine($"Last Element With Condition {lastCond}");

            int LastOrDef = emptyList.LastOrDefault();
            Console.WriteLine($"last or Default Element {LastOrDef}");
            #endregion
            #region ElementAt & ElementAtOrDefualt
            int eleAt = list.ElementAt(3);
            Console.WriteLine($"Element At {eleAt}");

            int eleAtOrDef = list.ElementAt(9);
            Console.WriteLine($"Element At or Default {eleAtOrDef}");
            #endregion
            #region Single & SingleOrDefualt
            #endregion
            #endregion
        }
    }
}
