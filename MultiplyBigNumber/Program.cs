using System;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string longNumber = Console.ReadLine().TrimStart('0');
            int num = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int firstDigit = 0;
            if (num == 0 || longNumber == "")
            {
                Console.WriteLine(0);
                return;
            }
            foreach (char ch in longNumber.Reverse())
            {
                int digit = int.Parse(ch.ToString());
                int result = digit * num + firstDigit;

                int restDigit = result % 10;
                firstDigit = result / 10;
                sb.Insert(0, restDigit);
            }
            if (firstDigit > 0)
            {
                sb.Insert(0, firstDigit);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
