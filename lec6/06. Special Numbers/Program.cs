using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1111; i <= 9999; i++)
            {
                int failedDivides = 0;
                string divider = (i.ToString());
                for(int number = 0; number < 4; number++)
                {
                    string singleNumber = divider[number].ToString();
                    int dividerNum = int.Parse(singleNumber);
                    if (dividerNum != 0)
                    {
                        if (n % dividerNum != 0)
                            failedDivides++;
                    }
                    else
                        failedDivides++;
                    
                }
                if (failedDivides == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
