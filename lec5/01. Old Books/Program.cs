using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            string command = "";
            int booksChecked = 0;

            while (true)
            {
                command = Console.ReadLine();
                
                if (command == "No More Books")
                {
                    Console.WriteLine($"The book you search is not here!\nYou checked {booksChecked} books.");
                    break;
                }
                if (command == bookName)
                {
                    Console.WriteLine($"You checked {booksChecked} books and found it.");
                    break;
                }
                booksChecked++;
            }
        }
    }
}
