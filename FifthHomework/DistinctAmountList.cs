using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthHomework
{
    static class DistinctAmountList
    {
        public static Dictionary<T,int> DistinctAmount<T>(this List<T> list)
        {
            Dictionary<T, int> result = new Dictionary<T, int>();
            var dist = list.Distinct();
            for (int i = 0; i < dist.Count(); i++) 
            {
                var elem = dist.ElementAt(i);
                var amount = list.Count(x => x.Equals(elem));
                result.Add(elem, amount);
            }
            return result;
        }
    }
}
