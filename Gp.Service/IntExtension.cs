using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Service
{
    public static class IntExtension
    {
        public static bool IsGreat(this int a,int x)
        {
            return a > x;
        }
        public static string Strmeth(this string s, bool b, char c)
        {
            return b.ToString();
        }
    }
}
