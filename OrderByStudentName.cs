using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace LambdaExpression
{
    public class OrderByStudentName

    {
        public string name
        {
            get;
            set;
        }

        public int age
        {
            get;
            set;
        }


        public static void Main(string[] args)
        {

            Square();
            DivisibleBy3();
            DivisibleBy5();
            List<OrderByStudentName> list = new List<OrderByStudentName>()
            {
                new OrderByStudentName { name = "ram", age = 20 },
                new OrderByStudentName { name = "sam", age = 30 },
                new OrderByStudentName { name = "tom", age = 40 }
            };

            //var Asc = list.OrderBy(x => x.name);
            var Desc=list.OrderByDescending(x => x.name);

            foreach (var x in Desc)
            {
                Console.WriteLine(x.name + " " + x.age);
            }
        }

        //--------------------------------------------------

        public static void Square()
        {
            List<int> list = new List<int>() { 10, 20, 30, 40, 50 };
            var square = list.Select(x => x * x).ToList();

            foreach (var x in square)
            {
                Console.WriteLine(x);
                
            }
            Console.WriteLine("----------------------------------------");
        }

        public static void DivisibleBy3()
        {
            List<int> list = new List<int>() { 10, 20, 30, 40, 50,50 };
            var dist=list.Distinct().ToList();
            var ElementAtIndex=list.ElementAt(4);
            Console.WriteLine( ElementAtIndex);
            Console.WriteLine( "-----------------------------");
            var ContainSElement=list.Contains(4);

            var reverse = list.Reverse<int>(); 
            Console.WriteLine( ContainSElement);
            var First=list.FirstOrDefault();
            Console.WriteLine( "First:"+First);
            var Last =list.Last();
            Console.WriteLine( "last:"+Last);
            var All =list.All(list => true);
            Console.WriteLine( "all:"+All);

            //int[] Reverse=list.Reverse().toArray();
            //return;


            var FindAll=list.FindAll(list => true);
            Console.WriteLine( "findall:"+FindAll);

            var any=list.Any(list => true);
            Console.WriteLine( "any:"+any);
            var square = list.Where(x => x %3==0).ToList();

            

            foreach (var x in square)
            {
                Console.WriteLine(x);
                
            }
            Console.WriteLine( "-----------------------------------");
        }

        public static void DivisibleBy5()
        {
            List<int> list = new List<int>() { 10, 20, 30, 40, 50 };
            var square = list.FindAll(x => x % 5 == 0).ToList();

            foreach (var x in square)
            {
                Console.WriteLine(x);

            }
            Console.WriteLine( "------------------------------------");
        }


    }
}
        
            

    

