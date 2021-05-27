using System;

namespace classLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("name:");
            string name = Console.ReadLine();
            numNums();
            Console.WriteLine(name);

        }

        static void numNums()
        {
            Console.WriteLine("integer between 1 and 100:");
            int.TryParse(Console.ReadLine(), out int num1);
            
            if (num1 >= 1 && num1 <= 100)
            {
                if (num1 % 2 == 0 && num1 <= 25)
                {
                    Console.WriteLine("even and less than 25");
                }
                else if (num1 % 2 == 0 && num1 <= 60)
                {
                    Console.WriteLine("even");
                }
                else if (num1 % 2 == 0 && num1 >= 61)
                {
                    Console.WriteLine(num1 + " even");
                }
                else if (num1 > 60)
                {
                    Console.WriteLine(num1 + " odd");
                }
                else
                {
                    Console.WriteLine("odd ");
                }

                Console.WriteLine("continue: y/n?");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    numNums();
                }
                else
                {
                    Console.WriteLine("bye bye ");
                }
            }
            else
            {
                Console.WriteLine("invalid entry, please try again");
                numNums();
            }

        }
    }
}
