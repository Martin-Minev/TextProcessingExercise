using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split();
            var firstWord = tokens[0];
            var secondWord = tokens[1];

            string longerWord = firstWord;
            string shorterWord = secondWord;

            if (firstWord.Length < secondWord.Length)
            {
                longerWord = secondWord;
                shorterWord = firstWord;
            }
            int total = CharMultiplier(longerWord, shorterWord);
            Console.WriteLine(total);
        }
        public static int CharMultiplier(string longerWord, string shorterWord)
        {
            int sum = 0;
            for (int i = 0; i < shorterWord.Length; i++)
            {
                int multiply = longerWord[i] * shorterWord[i];
                sum += multiply;
            }

            for (int i = shorterWord.Length; i < longerWord.Length; i++)
            {
                sum += longerWord[i];
            }
            return sum;
        }
    }
}
