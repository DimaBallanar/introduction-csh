using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        #region Task1 
        // Написать метод, рассчитывающий число из рада Фиббоначчи используя
        // рекурсию
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, …

        static void Task1()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(NumberFB(n));
        }

        static int NumberFB(int n)
        {
            if (n <= 1) { return n; }
            return NumberFB(n - 2) + NumberFB(n - 1);
        }
        #endregion
    }

}



