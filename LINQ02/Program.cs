using ASSLINQ;
using System;
using System.Collections;
using System.Collections.Generic;
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
        }
    }
}
