using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthHomework
{
    static class Extentions
    {
        public static int SymbolCount(this string str)
        {
            int res = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsSymbol(str[i])) res++;
            }
            return res;
        }
    }
}
