using ASSLINQ;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static ASSLINQ.ListGenerators;

namespace LINQ02
{
    

    internal class Program
    {
        static void Main()
        {
            #region Q1
            //1.Get first Product out of Stock
            var first=ProductList.First(x=>x.UnitsInStock==0);
            Console.WriteLine(first);



            #endregion
            #region Q2 
            //2.Return the first product whose Price > 1000, unless there is no match,
            //in which case null is returned.

            var p=ProductList.First(x=>x.UnitPrice>1000);
            Console.WriteLine(p);

            #endregion
            #region Q3
            //3.Retrieve the second number greater than 5
             int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var secnum = Arr.Where(n => n > 5)
                .Skip(1).First();
            Console.WriteLine(secnum);






            #endregion
        }
    }
}
