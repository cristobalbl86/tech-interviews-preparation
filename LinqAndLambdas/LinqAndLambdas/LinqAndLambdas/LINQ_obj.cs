using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAndLambdas
{
    public class LINQ_obj
    {
        public static void MainMethod()
        {
            List<Person> people = new List<Person>()
            {
                new Person("Felipe",22, Gender.Male),
                new Person("Francisco",29, Gender.Male),
                new Person("Antonio", 24, Gender.Male),
                new Person("Vicente",40, Gender.Male),
                new Person("Amado",29, Gender.Male),
                new Person("Cristobal",33, Gender.Male),
                new Person("Brenda",36, Gender.Female),
                new Person("Victoria",33, Gender.Female),
                new Person("Antonio", 33, Gender.Male),
            };


            //var Apeople = from p in people
            //              where p.Name.StartsWith("A")
            //              orderby p.Name ascending, p.Age descending
            //              select p;

            //foreach (var item in Apeople)
            //{
            //    Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
            //}

            //DIFFERENCE BETWEEN SELECT AND WHERE
            /*
            var twenties = people.Where(pp => (pp.Age > 20 && pp.Age < 30));
            var twentiesel = people.Select(pp => pp.Name);//   Where(pp => (pp.Age > 20 && pp.Age < 30));
            var twentiessel2 = people.Where(pp => (pp.Age > 20 && pp.Age < 30))
                                 .Select(pp => pp.Name);

            foreach (var item in twenties)
            {
                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
            }
            Console.WriteLine("----------");
            foreach (string item in twentiesel)
            {
                Console.WriteLine($"Name: {item}");
            }
            Console.WriteLine("----------");
            foreach (string item in twentiessel2)
            {
                Console.WriteLine($"Name: {item}");
            }

            Console.WriteLine("----------");
            */

            //FOREACH INTO LISTS (USING LAMBDA)
            // applies only to List<>, the filter must be converted ToList()
            /*
            List<string> names = people.Where(pp => (pp.Age > 20 && pp.Age < 30))
                                 .Select(pp => pp.Name)
                                 .ToList();
            names.ForEach(n => Console.WriteLine(n));

            Console.WriteLine("----------");
            List<Person> lstpeople = people.Where(pp => (pp.Age > 20 && pp.Age < 30)).ToList();
            lstpeople.ForEach(p => Console.WriteLine(p.Name));

    */

            //GROUP BY
            Console.WriteLine("----------");
            //var groupGender = from p in people
            //                  group p by p.Gender;
            var groupGender = people.GroupBy(p => p.Gender);

            foreach (var person in groupGender)
            {
                Console.WriteLine(person.Key);
                foreach (var item in person)
                {
                    Console.WriteLine($"  {item.Name} - {item.Gender}");
                }
            }

            Console.WriteLine("----------");
            //var groupbycondition = from p in people
            //                       where p.Age > 20
            //                       group p by p.Age;
            var groupbycondition = people.Where(p => p.Age > 20).GroupBy(p => p.Age);
            foreach (var person in groupbycondition)
            {
                Console.WriteLine(person.Key);
                foreach (var item in person)
                {
                    Console.WriteLine($"  {item.Name} - {item.Age}");
                }
            }

            Console.WriteLine("----------");
            //var groupbyalphabet = from p in people
            //                      orderby p.Name
            //                      group p by p.Name[0];
            var groupbyalphabet = people.OrderBy(p => p.Name).GroupBy(p => p.Name[0]);
            foreach (var person in groupbyalphabet)
            {
                Console.WriteLine(person.Key);
                foreach (var item in person)
                {
                    Console.WriteLine($"  {item.Name} - {item.Age}");
                }
            }

            Console.WriteLine("----------");
            //GROUP BY MULTI-KEY
            //var multikeygroup = from p in people
            //                    group p by new { p.Gender, p.Age };
            var multikeygroup = people.GroupBy(p => new { p.Gender, p.Age }).OrderByDescending(p => p.Count());
            foreach (var person in multikeygroup)
            {
                Console.WriteLine(person.Key);
                foreach (var item in person)
                {
                    Console.WriteLine($"  {item.Name}");
                }
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public Person(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
