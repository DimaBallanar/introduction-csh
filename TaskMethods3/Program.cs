using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            // Task3();
            // Task4();
            Task5();
            // Task7();

        }

        #region Task1 
        // Написать метод, рассчитывающий число из рада Фиббоначчи используя
        // рекурсию
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, …

        static void Task1()
        {
            System.Console.WriteLine("Task1");
            int n = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(NumberFB(n));
        }

        static int NumberFB(int n)
        {
            if (n <= 1) { return n; }
            return NumberFB(n - 2) + NumberFB(n - 1);
        }
        #endregion
        #region Task2
        //Дано натуральное число (вводится с клавиатуры). Вычислите сумму его цифр
        // используя рекурсию
        static void Task2()
        {
            System.Console.WriteLine("Task2");
            int number = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(SumNumber(number));
        }
        static int SumNumber(int number)
        {

            int sum = 0;
            if (number == 0)
            {
                return sum;
            }
            sum = number % 10 + SumNumber(number / 10);
            return sum;
        }
        #endregion
        #region Task7
        static void Task7()
        {
            System.Console.WriteLine("Task7");
            string? text = Console.ReadLine();
            string? symbol = Console.ReadLine();
            if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(symbol))
            {
                Console.WriteLine(MethodAllSearch(text, symbol));
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        static (string, int, int, int) MethodAllSearch(string text, string symbol)
        {
            int count = 0;
            int indexFirst = -1;
            int indexLast = -1;
            int LengthSymbol = symbol.Length;
            for (int i = 0; i <= text.Length - LengthSymbol; i++)
            {
                string temp = "";
                for (int j = i; j <= i + (LengthSymbol - 1); j++)
                {
                    temp += text[j];
                }
                if (temp == symbol)
                {
                    if (indexFirst == -1)
                    {
                        indexFirst = i;
                    }
                    indexLast = i;
                    count++;
                }
            }
            return (symbol, count, indexFirst, indexLast);
        }
        #endregion
        #region Task3 
        //     Дано натуральное число больше 1 (вводится с Выведите все простые
        // делители этого числа используя рекурсию
        static void Task3()
        {
            System.Console.WriteLine("Task3");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            System.Console.WriteLine(SearchSimpleNumber(ref number, ref count));
        }
        static int SearchSimpleNumber(ref int number, ref int count)
        {

            if (number > 1 && count == 0)
            {
                count++;
                System.Console.WriteLine(1);
                return SearchSimpleNumber(ref number, ref count);
            }
            if (number % 2 == 0)
            {
                number = number / 2;
                count++;
                System.Console.WriteLine(2);
                return SearchSimpleNumber(ref number, ref count);
            }
            if (number % 3 == 0)
            {
                number = number / 3;
                count++;
                System.Console.WriteLine(3);
                return SearchSimpleNumber(ref number, ref count);
            }
            if (number % 5 == 0)
            {
                number = number / 5;
                count++;
                System.Console.WriteLine(5);
                return SearchSimpleNumber(ref number, ref count);
            }
            if (number % 7 == 0)
            {
                number = number / 7;
                count++;
                System.Console.WriteLine(7);
                return SearchSimpleNumber(ref number, ref count);
            }
            return count;
        }
        #endregion
        #region Task4
        static void Task4()
        {
            System.Console.WriteLine("Task4");
            double number = double.Parse(Console.ReadLine());

            System.Console.WriteLine(Degree2(ref number));
        }
        static double Degree2(ref double number)
        {
            string itog = "«Not degree 2»";
            if (number == 1)
            {
                System.Console.WriteLine("«degree 2»");
                return 1;
            }
            else if (number > 1 && number < 2)
            {
                System.Console.WriteLine("«Not degree 2»");
                return -1;
            }
            else
            {
                number = number / 2;
                return Degree2(ref number);
            }
        }
        #endregion
        //         Дано натуральное число больше 1 (вводится с клавиатуры). Выведите «Точная
        // степень двойки», если число является точной степенью двойки, или «Не
        // являеться степенью двойки», в противном случае используя рекурсию
        // #region Task4
        // //     Дано натуральное число больше 1 (вводится с клавиатуры). Выведите «Точная
        // // степень двойки», если число является точной степенью двойки, или «Не
        // // являеться степенью двойки», в противном случае используя рекурсию.
        // static void Task4()
        // {
        //     System.Console.WriteLine("Task4");
        //     double number = double.Parse(Console.ReadLine());
        //     System.Console.WriteLine(Degree2(ref number));
        // }
        // static double Degree2(ref double number)
        // {
        //     do
        //     {
        //         number = number / 2;
        //         if (number == 1)
        //         {
        //             System.Console.WriteLine("«degree 2»");
        //             return 1;
        //         }
        //         return Degree2(ref number);
        //     }
        //     while (number == 1 || number < 2 && number > 1);
        //     return -1;
        // }
        // #endregion
        #region Task5
        //     Написать метод возвращающий индекс максимального и минимального
        // значения массива (два способа используя кортеж и out)
        static void Task5()
        {
            System.Console.WriteLine("Task5");
            int[] arraytask5 = new int[5] { 1, 2, 6, 7, 9 };
            System.Console.WriteLine(MetodReturnIndex(arraytask5));
            OutFindMinMax(arraytask5, out int minnumberindex, out int maxnumberindex);
            System.Console.WriteLine($"indexMin-{minnumberindex},indexMax-{maxnumberindex}");
        }
        static (int, int) MetodReturnIndex(int[] array)
        {
            int maxnumberindex = 0;
            int minnumberindex = 0;
            int maxnumber = array[0];
            int minnumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= minnumber)
                {
                    minnumberindex = i;
                }
                if (array[i] >= maxnumber)
                {
                    maxnumberindex = i;
                }
            }
            return (maxnumberindex, minnumberindex);
        }
        static void OutFindMinMax(int[] massiv, out int minnumberindex, out int maxnumberindex)
        {
            maxnumberindex = 0;
            minnumberindex = 0;
            int maxnumber = massiv[0];
            int minnumber = massiv[0];
            for (int i = 1; i < massiv.Length; i++)
            {
                if (maxnumber < massiv[i])
                {
                    minnumberindex = i;
                }
                if (minnumber > massiv[i])
                {
                    maxnumberindex = i;
                }
            }
        }
        #endregion
    }
}





