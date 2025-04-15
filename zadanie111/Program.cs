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

            // Tworzymy tablicę z liczbami
            double[] numbers = { firstNumber, secondNumber };

            // Sortujemy tablicę
            Array.Sort(numbers);

            // Wyświetlamy posortowane liczby
            Console.WriteLine("Posortowane liczby: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.Write("Podaj operator (+, -, *, /): ");
            char operation = Console.ReadLine()[0];

            double result;

            switch (operation)
            {
                case '+':
                    result = numbers[0] + numbers[1];  // Dodajemy posortowane liczby
                    break;
                case '-':
                    result = numbers[1] - numbers[0];  // Odejmujemy mniejszą od większej
                    break;
                case '*':
                    result = numbers[0] * numbers[1];  // Mnożymy posortowane liczby
                    break;
                case '/':
                    if (numbers[1] != 0)  // Dzielimy większą przez mniejszą
                    {
                        result = numbers[1] / numbers[0];
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
