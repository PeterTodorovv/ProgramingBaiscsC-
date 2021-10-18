using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int currentN = n1; currentN <= n2; currentN++)
            {
                int oddSum = 0;
                int evenSum = 0;
                string sCurrentN = currentN.ToString();
                for (int n = 0; n< sCurrentN.Length; n++)
                {
                    if (n % 2 == 0)
                        evenSum += int.Parse(sCurrentN[n].ToString());
                    else
                        oddSum += int.Parse(sCurrentN[n].ToString());
                }
                if (evenSum == oddSum)
                    Console.Write(currentN + " ");
            }
        }
    }
}
