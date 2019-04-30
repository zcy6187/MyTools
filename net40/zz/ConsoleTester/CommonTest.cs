using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTester
{
    class CommonTest
    {
        public static void TestPocoMap()
        {
            Dog dog = new Dog();
            dog.Name = "Dgg";
            dog.Age = 10;

            Cat cc=Utils.PocoMap.MapSamePropertyToOther<Dog, Cat>(dog);
            Console.WriteLine(cc.Age);
            Console.WriteLine(cc.Name);
            Console.WriteLine(cc.Index);
        }
    }

    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Index { get; set; }
    }
}
