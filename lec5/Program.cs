using System;

namespace lec5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word = Console.ReadLine();
                if (word != "Stop")
                    Console.WriteLine(word);
                else
                    break;
            }
        }
    }
}
