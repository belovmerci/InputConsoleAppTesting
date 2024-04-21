using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputConsoleAppTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа для создания матрицы умножения:");
            Console.Write("Первое число: ");
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("Ошибка: Введено некорректное значение для первого числа.");
                return;
            }

            Console.Write("Второе число: ");
            if (!int.TryParse(Console.ReadLine(), out int y))
            {
                Console.WriteLine("Ошибка: Введено некорректное значение для второго числа.");
                return;
            }

            Console.WriteLine("Матрица умножения:");
            int[,] multiplicationMatrix = MatrixMultiplier.GenerateMultiplicationMatrix(x, y);
            PrintMatrix(multiplicationMatrix);
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
