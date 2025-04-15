using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosty Kalkulator");
            Console.WriteLine("-------------------");

            Console.Write("Podaj pierwszą liczbę: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj operator (+, -, *, /): ");
            char operation = Console.ReadLine()[0];

            double result;

            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                    }
                    else
                    {
                        Console.WriteLine("Nie można dzielić przez zero!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy operator!");
                    return;
            }

            Console.WriteLine($"Wynik: {result}");
        }
    }
}
