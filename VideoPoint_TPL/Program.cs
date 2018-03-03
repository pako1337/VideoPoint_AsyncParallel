using System;
using System.Diagnostics;

namespace VideoPoint_TPL
{
    public static class Program
    {
        private static Random rnd = new Random(1);
        private static int matrixSize = 600;

        static void Main(string[] args)
        {
            var m1 = new Matrix(GenerateMatrixValues(matrixSize));
            var m2 = new Matrix(GenerateMatrixValues(matrixSize));

            var sequentialStopWatch = new Stopwatch();
            sequentialStopWatch.Start();
            m1.Multiply(m2);
            sequentialStopWatch.Stop();

            Console.WriteLine("Sekwencyjne: {0}", sequentialStopWatch.Elapsed);

            var parallelWatch = new Stopwatch();
            parallelWatch.Start();
            m1.MultiplyParallelRow(m2);
            parallelWatch.Stop();

            Console.WriteLine("Współbieżne: {0}", parallelWatch.Elapsed);

            Console.WriteLine("Skala przyspieszenia: {0}", (double)sequentialStopWatch.ElapsedMilliseconds / parallelWatch.ElapsedMilliseconds);
        }

        private static int[][] GenerateMatrixValues(int matrixSize)
        {
            var values = new int[matrixSize][];

            for (int i = 0; i < matrixSize; i++)
            {
                values[i] = new int[matrixSize];
                for (int j = 0; j < matrixSize; j++)
                    values[i][j] = rnd.Next(1_000);
            }

            return values;
        }
    }
}
