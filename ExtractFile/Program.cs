using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(@"\");

            string lastFile = input[input.Length-1];

            var array = lastFile.Split(".");

           Console.WriteLine($"File name: {array[0]}");
           Console.WriteLine($"File extension: {array[1]}");
        }
    }
}
