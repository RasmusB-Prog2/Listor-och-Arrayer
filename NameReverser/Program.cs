using System;
using System.Collections.Generic;
using System.Linq;

namespace NameReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = GetNames();

            foreach (var name in names)
            {
                var chars = name.ToCharArray();
                chars = chars.Reverse().ToArray();
                foreach (var c in chars)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }

            var testList = new List<string>{"qwerty", "asdf", "1234", "5678"};
            testList.ForEach(Console.WriteLine);
        }



        private static void Print(string content)
        {
            Console.WriteLine(content);
        }

        private static IEnumerable<string> GetNames()
        {
            var names = new List<string>();

            for (var i = 0; i < 5; i++)
            {
                names.Add(Console.ReadLine()?.ToLower());
            }
            Console.WriteLine("---");
            return names;
        }
    }
}
