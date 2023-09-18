using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите значение N: ");
        if (int.TryParse(Console.ReadLine(), out int N))
        {
            if (N > 0)
            {
                PrintNumbersFromNTo1(N);
            }
            else
            {
                Console.WriteLine("N должно быть положительным числом.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое положительное число.");
        }
    }

    public static void PrintNumbersFromNTo1(int N)
    {
        if (N < 1)
            return;

        Console.Write(N);

        if (N > 1)
            Console.Write(", ");

        PrintNumbersFromNTo1(N - 1);
    }
}
