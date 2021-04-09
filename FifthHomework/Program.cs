using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "++11$$22||  ==";
            Console.WriteLine($"В строке : {str} , содержится {str.SymbolCount()} символов." );
            Console.ReadKey();
            List<int> ints = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 6, 5, 4, 3, 2, 1, 0, 2, 2, 6 });
            Dictionary<int, int> numbersAmount = new Dictionary<int, int>();
            numbersAmount = ints.DistinctAmount();
            foreach(var elem in numbersAmount)
            {
                Console.WriteLine($"Элемент :{elem.Key}, кол-во: {elem.Value} ");
            }            
            Console.ReadKey();
            List<string> words = new List<string>(new string[] { "good", "bad", "ok", "good", "ok", "ok" });
            Dictionary<string, int> stringsAmount = new Dictionary<string, int>();
            stringsAmount = words.DistinctAmount();
            foreach (var elem in stringsAmount)
            {
                Console.WriteLine($"Элемент :{elem.Key}, кол-во: {elem.Value} ");
            }
            Console.ReadKey();
        }       
    }
}
