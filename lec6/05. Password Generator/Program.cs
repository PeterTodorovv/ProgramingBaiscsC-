using System;

namespace _05._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for(int firstNum=1; firstNum < n; firstNum++)
            {
                for (int secondNum = 1; secondNum < n; secondNum++)
                {
                    for( int firstLetter = 97; firstLetter < 97 + l; firstLetter++)
                    {
                        for (int secondLetter = 97; secondLetter < 97 + l; secondLetter++)
                        {
                            int lastNumber = 1;
                            while(lastNumber <= n)
                            {

                                if (lastNumber > firstNum && lastNumber > secondNum)
                                    Console.Write($"{firstNum}{secondNum}{(char)firstLetter}{(char)secondLetter}{lastNumber} ");  
                                lastNumber++;
                            }
                        }
                    }
                }
            }

        }
    }
}
