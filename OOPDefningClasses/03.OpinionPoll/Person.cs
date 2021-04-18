using System;
using System.Collections.Generic;
using System.Text;

namespace _03.OpinionPoll
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
