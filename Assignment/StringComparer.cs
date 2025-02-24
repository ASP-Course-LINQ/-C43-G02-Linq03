using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class StringComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return new string(x.OrderBy(c => c).ToArray()) == new string(y.OrderBy(c => c).ToArray());
        }

        public int GetHashCode(string obj)
        {
            return new string(obj.OrderBy(c => c).ToArray()).GetHashCode();
        }

    }
}
