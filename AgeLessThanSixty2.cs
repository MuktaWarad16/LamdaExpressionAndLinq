//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace LambdaExpression
//{
//    internal class Top2Ages
//    {
//        class Person
//        {
//            public string Name { get; set; }
//            public int Age { get; set; }
//        }

//       public  static void Age()
//        {
//            List<Person> people = new List<Person>
//            {new Person { Name="ram",Age=45},new Person {Name="Laxman",Age=25 } };
           
//            var top=people.Where(person=>person.Age<60).Take(2).Select(person => person.Age).ToList();

//            foreach (var age in top)
//            {
//                Console.WriteLine(age);
//            }
//        }
//    }
//}
