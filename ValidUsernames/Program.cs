using System;
using System.Linq; 

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
           var input= Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                var current = input[i];
                if (IsValid(current))
                {
                    Console.WriteLine(current);
                }
            }
        }
        static bool IsValid(string cur)
        {
            return cur.Length >= 3 && cur.Length <= 16&& cur.All(c => char.IsLetterOrDigit(c))
                || cur.Contains("-") || cur.Contains("_");
           
        }
    }
}
