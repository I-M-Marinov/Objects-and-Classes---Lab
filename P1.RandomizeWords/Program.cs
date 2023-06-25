using System;
using System.Linq;

namespace P1.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            Random rnd = new Random();

            for (int pos1 = 0; pos1 < words.Length-1; pos1++)
            {
                int pos2 = rnd.Next(0, words.Length-1);

                string currentWord = words[pos1];
                string randomWord = words[pos2];


                words[pos1] = randomWord;
                words[pos2] = currentWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
