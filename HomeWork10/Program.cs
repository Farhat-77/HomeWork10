using System;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of Employees; ");
            int i = 0;
            int s = int.Parse(Console.ReadLine());

            while (i < s)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Enter id: ");
                int _id = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Enter Name: ");
                string nm = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Enter Salary: ");
                double sal = int.Parse(Console.ReadLine());
                i++;
            }
        }

    }
}

