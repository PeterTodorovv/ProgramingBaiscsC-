using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int totalBadGrades = 0;
            string lastProblem = "";
            double average = 0;
            int totalProblems = 0;

            while (true)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    Console.WriteLine($"Average score: {(average/totalProblems):f2}");
                    Console.WriteLine($"Number of problems: {totalProblems}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                average += grade;
                totalProblems++;

                if (grade <= 4)
                    totalBadGrades++;
                if (totalBadGrades >= badGrades)
                {
                    Console.WriteLine($"You need a break, {totalBadGrades} poor grades.");
                    break;
                }
                lastProblem = problemName;


            }
            
        }
    }
}
