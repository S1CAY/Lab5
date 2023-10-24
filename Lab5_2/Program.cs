using System;

namespace Lab5_2
{ 

class Program
{
    static void Main()
    {
        int num1 = 5;
        int num2 = 10;
        int sum = MathOperations.Add(num1, num2);
        Console.WriteLine($"Сума чисел: {sum}");

        double[] array1 = { 1.5, 2.5, 3.5 };
        double[] array2 = { 0.5, 1.5, 2.5 };
        double[] arraySum = MathOperations.Add(array1, array2);
        Console.WriteLine($"Сума масивів: [{string.Join(", ", arraySum)}]");

        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 2, 3 }, { 4, 5 } };
        int[,] matrixSum = MathOperations.Add(matrix1, matrix2);
        Console.WriteLine("Сума матриць:");
        for (int i = 0; i < matrixSum.GetLength(0); i++)
        {
            for (int j = 0; j < matrixSum.GetLength(1); j++)
            {
                Console.Write(matrixSum[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
}