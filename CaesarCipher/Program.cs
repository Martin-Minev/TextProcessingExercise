using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder encrypted = new StringBuilder();
            foreach (char ch in input)
            {
              encrypted.Append((char)(ch+3));
            }
            Console.WriteLine(encrypted);
        }
    }
}
