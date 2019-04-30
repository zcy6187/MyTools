using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonTest.TestPocoMap();
            Console.ReadKey();
        }


        static void ShowIndividualCharacters(PropertyInfo pinfo,
                                         object value,
                                         params int[] indexes)
        {
            foreach (var index in indexes)
                Console.WriteLine("Character in position {0,2}: '{1}'",
                                  index, pinfo.GetValue(value, new object[] { index }));
            Console.WriteLine();
        }
    }
}
