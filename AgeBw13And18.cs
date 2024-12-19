//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace LambdaExpression
//{
//    internal class AgeFilter
//    {
//        class Person
//        {
//            public string Name { get; set; }
//            public int Age { get; set; }
//        }

//        public static void Meth()
//        {
            
//            List<Person> people = new List<Person>
//            {
//                new Person { Name = "Alice", Age = 12 },
//                new Person { Name = "Bob", Age = 15 },
                
//            };
//            var P = people.Where(person => person.Age>=13&& person.Age<= 18).ToList();

//            if (P.Any())
//            {
//                Console.WriteLine("People aged between 13 and 18:");
//                foreach (var person in P)
//                {
//                    Console.WriteLine(person.Name+person.Age);
//                }
//            }
//            else
//            {
//                Console.WriteLine("No records");
//            }
//        }
//    }
//}
