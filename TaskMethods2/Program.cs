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
        //Task1 10,2------------------------------------
        // Написать методы с ипользованием лямбда-оператора по выполнению
        // арифметических операций (+, -, /, *, % и другие). Вызов данных методов произвести
        // с использованием тернарного switch в методе.
        static void Task1()
        {
            int number1;
            number1 = 5;
            int number2 = 13;
            string? opr = Console.ReadLine();

            System.Console.WriteLine(Switch(opr: opr, number1: number1, number2: number2));
            // System.Console.WriteLine(MethodSum(number1, number2));
            // System.Console.WriteLine(MethodDeference(number1, number2));
            // System.Console.WriteLine(MethodMultiplication(number1, number2));
            // System.Console.WriteLine(MethodDivision(number1, number2));
        }

        static int MethodSum(int number, int number1) => number + number1;
        static int MethodDeference(int number, int number1) => number - number1;
        static int MethodMultiplication(int number, int number1) => number * number1;
        static int MethodDivision(int number, int number1) => number / number1;

        static string Switch(int number1, int number2, string opr) => opr switch
        {
            "+" => MethodSum(number1, number2).ToString(),
            "-" => MethodDeference(number1, number2).ToString(),
            "*" => MethodMultiplication(number1, number2).ToString(),
            "/" => MethodDivision(number1, number2).ToString(),
            _ => string.Format("No resultations {0}", opr)
        };
        #endregion
    }

}



