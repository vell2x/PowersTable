using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "Y";

            Console.WriteLine("Welcome to the Square Cubed calculator!");

            while (!cont.Equals("N") && !cont.Equals("n"))
            {
                Console.Write("Enter an integer: ");
                int input = Convert.ToInt32(Console.ReadLine());

                String s = String.Format("{0, -10} {1, -10} {2, -10}\n\n", "Number", "Squared", "Cubed");
                for (int i = 1; i <= input; i++)
                    s += String.Format("{0, -10} {1, -10} {2, -10:N0}\n", i, i * i, i * i * i);
                Console.WriteLine($"\n{s}");

                Console.Write("Do you want to continue?(y/n): ");
                cont = Console.ReadLine();
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
