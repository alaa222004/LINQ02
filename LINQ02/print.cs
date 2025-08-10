using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ02
{
    public static class Extensions
    {
        public static void Print(this object obj)=>Console.WriteLine(obj);
        public static void Print<T>(this IEnumerable<T> collection)
        {
            if (collection is IEnumerable<char> && collection is string str)
            {
                Console.WriteLine(str);
                return;
            }

            foreach (var item in collection)
            {
                if (item is IEnumerable subCollection && !(item is string))
                {
                    foreach (var subItem in subCollection)
                    {
                        Console.WriteLine(subItem?.ToString());
                    }
                }
                else
                {
                    Console.WriteLine(item?.ToString());
                }
            }
        }
    }

}
