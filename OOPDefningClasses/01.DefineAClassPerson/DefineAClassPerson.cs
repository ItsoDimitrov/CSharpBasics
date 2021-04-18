using _01.DefineAClassPerson;
using System;
using System.Reflection;

namespace _01.Test
{
    class DefineAClassPerson
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            var pesho = new Person
            {
                personName = "Pesho",
                personAge = 20
            };
            Console.WriteLine(pesho);

            var gosho = new Person
            {
                personName = "Gosho",
                personAge = 18
            };

            var stamat = new Person
            {
                personName = "Stamat",
                personAge = 43
            };

        }
    }
}
