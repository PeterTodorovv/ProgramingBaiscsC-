using System;

namespace _06._Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int couneter = 0; 

            for(int n11 = K; n11<= 8; n11++)
            {
                for (int n12 = 9; n12 >= L; n12--)
                {
                    for (int n21 = M; n21 <= 8; n21++)
                    {
                        for (int n22 = 9; n22 >= N; n22--)
                        {
                            if (n11 % 2 ==0 &&  n12 %2==1 && n21 % 2 == 0 && n22 % 2 == 1 && n21 %2 != n22 % 2)
                            {
                                if (n11 != n21 || n12 != n22)
                                {
                                    Console.WriteLine($"{n11}{n12} - {n21}{n22}");
                                    couneter++;
                                    if (couneter == 6)
                                        return;
                                }
                                else
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                
                            }
                        }
                    }
                }
                
            }
        }
    }
}
