using System.Text.RegularExpressions;

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
            ////int first=list.First();
            ////Console.WriteLine($"First Element {first}");

            ////var cond = list.First(n=>n>3);
            ////Console.WriteLine($"First Element With Condition {cond}");

            ////int firstOrDef = emptyList.FirstOrDefault();
            ////Console.WriteLine($"First or Default Element {firstOrDef}");
            #endregion
            #region Last & LastOrDefualt
            ////int last = list.Last();
            ////Console.WriteLine($"Last Element {last}");

            ////var lastCond = list.Last(n => n > 3);
            ////Console.WriteLine($"Last Element With Condition {lastCond}");

            ////int LastOrDef = emptyList.LastOrDefault();
            ////Console.WriteLine($"last or Default Element {LastOrDef}");
            #endregion
            #region ElementAt & ElementAtOrDefualt
            ////int eleAt = list.ElementAt(3);
            ////Console.WriteLine($"Element At {eleAt}");

            ////int eleAtOrDef = list.ElementAt(9);
            ////string res= eleAtOrDef == null ? "no data" : eleAtOrDef.ToString();
            ////Console.WriteLine($"Element At or Default {res}");
            #endregion
            #region Single & SingleOrDefualt
            #endregion
            #endregion

            #region Grouping Operator
            var result = from l in list
                         group l by l % 2
                         into resgr
                         where resgr.Count()>1
                         select new {Numgroup=resgr.Key,Count=resgr.Count()};

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key+":");
            //    foreach (var item1 in item)
            //    {
            //        Console.Write(item1+" ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region let & Into
            ////var Names = new List<string>() { "Esraa", "Ahmed", "Ali", "Morad", "hassan" };
            ////var result = from s in Names
            ////             select Regex.Replace(s,"[aeiouAEIOU]", string.Empty)
            ////             into nonVowels //create new query
            ////             where nonVowels.Length>3 
            ////             select nonVowels;
            ////result = from s in Names
            ////         let nonVowels=
            ////             Regex.Replace(s, "[aeiouAEIOU]", string.Empty)                          
            ////             where nonVowels.Length > 3
            ////             select nonVowels;
            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item);
            ////}
            #endregion
        }
    }
}
