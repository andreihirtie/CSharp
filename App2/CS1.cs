using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace stringTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            var NoArray = new List<UInt16> { 0, 1, 2, 3, 4, 5};

            foreach (UInt16 element in NoArray)
            {
                //Console.WriteLine("Hi");
                Console.WriteLine($"Element #{count}: {element}");
                Console.WriteLine("Element #{0}: {1}", count, NoArray[count]);
                count++;
            }

            string[] progArgs = Environment.GetCommandLineArgs();

            Console.WriteLine(string.Join(", ", progArgs));

            for (var i = 0; i < args.Length; i++)
                Console.WriteLine(args[i]);

            myFunct();
        }

        private static void myFunct()
        {
            string name = "";
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            // byte - 1 byte char unsigned
            // sbyte - 1 byte char signed
            // short - 16 bit signed int 
            // ushort - 16 bit unsigned int
            // char - 16 bit unicode char
            // int - 32 bits
            // uint - 32 bit uint
            // float - 32 bit fp number - half as accurate as a double
            // long - 64 bits 
            // double - 64 bits - decimal is more precise -- has speed advantage over decimal but not very accurate 
            // // for very large computations 
            // decimal - 128 bits - loses precision after 28 digits   
            // BigInteger - system numerics requried 

            //bool boolConv = bool.Parse("true"); // .Parse method - type.Parse 

            //Console.WriteLine($"Hello {name}");

            //Console.WriteLine($"Biggest long size: {long.MaxValue} ");
            //Console.WriteLine($"Min int size: {int.MinValue} ");

            //string myString = "Learning C# is fun!";

            //System.Console.WriteLine($"{myString} and my length is: {myString.Length} and i contain {myString.Contains("C#")}");

            //Console.WriteLine($"String index is: {myString.IndexOf("C#")} and I keep only first 6 digits {myString.Remove(0, 6)}");
        }
    }
}
