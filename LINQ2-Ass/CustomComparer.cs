using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2_Ass
{
    internal class CustomComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if (x == null || y == null || x.Length!=y.Length) return -1;
            foreach (char c in y)
            {
                if (x.IndexOf(c)<0)
                {
                    return -1;
                }
            }
            return 1;
        }

    }
}
