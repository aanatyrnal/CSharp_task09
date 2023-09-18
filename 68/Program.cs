using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите значение m: ");
        if (int.TryParse(Console.ReadLine(), out int m))
        {
            Console.Write("Введите значение n: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                long result = AckermannFunction(m, n);
                Console.WriteLine($"A({m}, {n}) = {result}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод для n. Пожалуйста, введите целое число.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод для m. Пожалуйста, введите целое число.");
        }
    }

    public static long AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, (int)AckermannFunction(m, n - 1));
        }
    }
}
