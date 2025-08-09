using ASSLINQ;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

            #region Q1P2
            //1.Uses Count to get the number of odd numbers in the array
int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Arr2.Count(x => x % 2 != 0).Print();


            #endregion

            #region Q2P2
            //2.Return a list of customers and how many orders each has.

            var res = CustomerList.Select(c => new
            {
                c.CustomerName,
                c.Orders
            });res.Print();
           

            #endregion
        }
    }
}
