using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number;
                int number2;
                int sign;
                int res;

                Console.WriteLine("Input your first number.");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose your math sign. 1: Addition, 2: Subtraction, 3: Multiplication, 4: Division");
                sign = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input your second number.");
                number2 = Convert.ToInt32(Console.ReadLine());

                if (sign == 1)
                {
                    res = number + number2;
                    Console.WriteLine(number + " + " + number2 + " = " + res);
                    Console.ReadLine();

                }
                else if (sign == 2)
                {
                    res = number - number2;
                    Console.WriteLine(number + " - " + number2 + " = " + res);
                    Console.ReadLine();
                }
                else if (sign == 3)
                {
                    res = number * number2;
                    Console.WriteLine(number + " * " + number2 + " = " + res);
                    Console.ReadLine();
                }
                else if (sign == 4)
                {
                    res = number / number2;
                    Console.WriteLine(number + " / " + number2 + " = " + res);
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("fuck you");
                }
            }
        }
    }
}
