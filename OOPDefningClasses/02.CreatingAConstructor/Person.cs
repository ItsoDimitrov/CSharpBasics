using System;
using System.Collections.Generic;
using System.Text;

namespace _02.CreatingAConstructor
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person()
        {
            name = "No name";
            age = 1;
        }
        public Person(int age)
        {
            this.age = age;
        }

        public Person(string name, int age) : this(age)
        {
            this.name = name;
        }
    }
}
