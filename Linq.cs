using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExpression
{
    internal class Linq
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>() {};
            //List<int> lt=list.Distinct().ToList();
           // List<int> asc = list.OrderByDescending(x=> x).ToList();
              //var first=list.First();
            var firstEmpty = list.FirstOrDefault();
             Console.WriteLine( firstEmpty);
            //
            //var odd = list.Where(x=>x % 2 != 0);
            //foreach (int num in asc)
            //{
            //    Console.WriteLine(num);
            //}

        }
    }
}
