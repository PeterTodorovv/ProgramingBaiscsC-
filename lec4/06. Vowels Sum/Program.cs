using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int total = 0;

            for(int i = 0; i<word.Length; i++)
            {
                char symbol = word[i];

                switch (symbol)
                {
                    case 'a':
                        total++;
                        break;
                    case 'e':
                        total += 2;
                        break;
                    case 'i':
                        total += 3;
                        break;
                    case 'o':
                        total += 4;
                        break;
                    case 'u':
                        total += 5;
                        break;

                }
            }
            Console.WriteLine(total);
        }
    }
}
