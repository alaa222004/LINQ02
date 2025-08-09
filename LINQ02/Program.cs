using ASSLINQ;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using static ASSLINQ.ListGenerators;
using System.IO;

namespace LINQ02
{
    

    internal class Program
    {
        static void Main()
        {
            #region Q1
            //1.Get first Product out of Stock
            var first = ProductList.First(x => x.UnitsInStock == 0);
            Console.WriteLine(first);



            #endregion
            #region Q2 
            //2.Return the first product whose Price > 1000, unless there is no match,
            //in which case null is returned.

            var p = ProductList.First(x => x.UnitPrice > 1000);
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
            }); res.Print();


            #endregion

            #region Q3P2
            //3.Return a list of categories and how many products each has

            var cat = ProductList.GroupBy(p => p.Category).Select(g => new
            {
                Category = g.Key,
                proudectcount = g.Count()
            });
            cat.Print();

            #endregion

            #region Q4P2
            //4.Get the total of the numbers in an array.
            int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var arr3 = Arr3.Sum();
            arr3.Print();

            #endregion

            #region Q5P2

            //5.Get the total number of characters of all words in dictionary_english.txt
            //    (Read dictionary_english.txt into Array of String First).


            string[] words = File.ReadAllLines("dictionary_english.txt");
            int totalChars = words.Sum(w => w.Length);
            totalChars.Print();

            #endregion

            #region Q6P2
            //6.Get the length of the shortest word in dictionary_english.txt
            //    (Read dictionary_english.txt into Array of String First).

            string[] word = File.ReadAllLines("dictionary_english.txt");
            int shortest = word.Min(w => w.Length);
            shortest.Print();



            #endregion

            #region Q7P2
            //7.Get the length of the longest word in dictionary_english.txt
            //    (Read dictionary_english.txt into Array of String First).

            string[] wordd = File.ReadAllLines("dictionary_english.txt");
            int longest=wordd.Max(m=>m.Length);
            longest.Print();

            #endregion

            #region Q8P2
            //8.Get the average length of the words in dictionary_english.txt
            //    (Read dictionary_english.txt into Array of String First).

            string[] worddd = File.ReadAllLines("dictionary_english.txt");
            double AVR = worddd.Average(m => m.Length);
            AVR.Print();

            #endregion

            #region Q9P2
            //9.Get the total units in stock for each product category.

            var result = ProductList.GroupBy(p => p.Category)
                .Select(g => new
    {
                 Category = g.Key,
                TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
    });

            result.Print();

            #endregion
        }
    }
}
