using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите значение M: ");
        if (int.TryParse(Console.ReadLine(), out int M))
        {
            Console.Write("Введите значение N: ");
            if (int.TryParse(Console.ReadLine(), out int N))
            {
                if (M <= N)
                {
                    int sum = SumNaturalNumbersInRange(M, N);
                    Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {sum}");
                }
                else
                {
                    Console.WriteLine("M должно быть меньше или равно N.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод для N. Пожалуйста, введите целое число.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод для M. Пожалуйста, введите целое число.");
        }
    }

    public static int SumNaturalNumbersInRange(int M, int N)
    {
        int sum = 0;

        for (int i = M; i <= N; i++)
        {
            sum += i;
        }

        return sum;
    }
}
