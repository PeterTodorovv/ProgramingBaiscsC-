using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for(int i = 0; i<=tabs; i++)
            {
                string tabName = Console.ReadLine();
                if (tabName == "Facebook")
                    salary -= 150;
                else if (tabName == "Instagram")
                    salary -= 100;
                else if (tabName == "Reddit")
                    salary -= 50;
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
        }
    }
}
