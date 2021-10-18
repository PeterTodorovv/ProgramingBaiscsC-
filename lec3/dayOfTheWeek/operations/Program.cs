using System;

namespace operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operators = Console.ReadLine();
            string type;
            double sum;

            switch (operators){
                case "+":
                    sum = N1 + N2;
                    if (sum % 2 == 0)
                    {
                        type = "even";
                    }
                    else
                    {
                        type = "odd";
                    }
                    Console.WriteLine($"{N1} + {N2} = {sum} - {type}");
                    break;
                case "-":
                    sum = N1 - N2;
                    if (sum % 2 == 0)
                    {
                        type = "even";
                    }
                    else
                    {
                        type = "odd";
                    }
                    Console.WriteLine($"{N1} - {N2} = {sum} - {type}");
                    break;
                case "*":
                    sum = N1 * N2;
                    if (sum % 2 == 0)
                    {
                        type = "even";
                    }
                    else
                    {
                        type = "odd";
                    }
                    Console.WriteLine($"{N1} * {N2} = {sum} - {type}");
                    break;
                case "/":
                    if(N2 != 0)
                    {
                        sum = Convert.ToDouble(N1) / N2;
                        Console.WriteLine($"{N1} / {N2} = {sum:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
                case "%":
                    if (N2 != 0)
                    {
                        sum = N1 % N2;
                        Console.WriteLine($"{N1} % {N2} = {sum}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;

            }
        }
    }
}
