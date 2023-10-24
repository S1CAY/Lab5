using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    public class MathOperations
    {
        public static T Add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }

        public static T[] Add<T>(T[] a, T[] b)
        {
            if (a.Length != b.Length)
                throw new ArgumentException("Розміри масивів не збігаються.");

            T[] result = new T[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = Add(a[i], b[i]);
            }
            return result;
        }

        public static T[,] Add<T>(T[,] a, T[,] b)
        {
            if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
                throw new ArgumentException("Розміри матриці не збігаються.");

            int rows = a.GetLength(0);
            int cols = a.GetLength(1);
            T[,] result = new T[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = Add(a[i, j], b[i, j]);
                }
            }
            return result;
        }


    }
}
