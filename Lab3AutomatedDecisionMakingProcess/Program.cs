using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3AutomatedDecisionMakingProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Please enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            string response = "y";

            while (response == "y")
            {
                Console.WriteLine(name + " Please enter a number between 1 and 100");
                int usernumber = int.Parse(Console.ReadLine());

                if (usernumber % 2 == 0 && usernumber >= 26)
                {
                    Console.WriteLine(name + " your number is " + usernumber + " EVEN ");
                }
                else if (usernumber % 2 == 0 && usernumber <= 25 && usernumber >= 2)
                {
                    Console.WriteLine(name + " your number is " + usernumber + " EVEN and less than 25 ");
                }
                else
                {
                    Console.WriteLine(name + " your number is " + usernumber + " ODD ");
                }
                Console.WriteLine("Type y to continue or press any other key exit: ");
                response = Console.ReadLine();
            }
            Console.WriteLine("Have a great day " + name + "!");
            Console.ReadLine();
        }
    }
}
