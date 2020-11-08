using System;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi skaitli x: ");
            string userInput1 = Console.ReadLine();
            double x = Convert.ToDouble(userInput1);

            Console.WriteLine("Ievadi skaitli y: ");
            string userInput2 = Console.ReadLine();
            double y = Convert.ToDouble(userInput2);

            Console.WriteLine("Ievadi aritmētisko operāciju +, -, / vai *: ");
            string userInput3 = Console.ReadLine();
            char z = Convert.ToChar(userInput3);

            if (z == '+')
            {
                Console.WriteLine(x + " + " + y + " = " + (Utils.Add(x, y)));
            }
            else if (z == '-')
            {
                Console.WriteLine(x + " - " + y + " = " + (Utils.Subtract(x, y)));
            }
            else if (z == '/')
            {
                Console.WriteLine(x + " / " + y + " = " + (Utils.Division(x, y)));
            }
            else if (z == '*')
            {
                Console.WriteLine(x + " * " + y + " = " + (Utils.Multiply(x, y)));
            }
            else
            {
                Console.WriteLine("Ievadītā aritmētiskā operācija neatbilst prasītajai!");
            }
        }
    }
}
