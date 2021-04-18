using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.OpinionPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> result = new List<Person>();
            for (int i = 1; i <= n; i++)
            {
                List<string> personInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                Person person = new Person(personInfo[0], int.Parse(personInfo[1]));
                result.Add(person);
            }
            Console.WriteLine();

            result.Where(p => p.age > 30)
                .OrderBy(p => p.name).ToList().ForEach(p => Console.WriteLine($"{p.name} - {p.age}"));
        }
    }
}
