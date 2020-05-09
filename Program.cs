using System;
using System.Text.RegularExpressions;
//using HumanKode.Extensions;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var patt = @"(?<nbr1>\w+)\s+(?<nbr2>\w+)";
            Console.WriteLine("Les's First VSCode application.");
            Console.WriteLine("Hello World!");
            while (true)
            {
                Console.WriteLine("Enter number1 and nunber2 to multiply or just press Enter to exit.");
                var line = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(line)) return;

                var m = Regex.Match(line, patt);
                if (!m.Success)
                {
                    Console.WriteLine("Invalid input, enter 2 numberss.");
                    continue;
                }

                var result = HumanKode.Extensions.Math.Multiply(int.Parse(m.Groups["nbr1"].Value), int.Parse(m.Groups["nbr2"].Value));
                Console.WriteLine("Result = " + result.ToString());
             }
        }

        private void TestMethod()
        {
            // test code goes here.
            // just testing, no code yet
            //still no codee.....
            // still none
			//not yet

        }
    }
}
