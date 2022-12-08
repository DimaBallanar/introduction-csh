using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
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
        #region Task2 
        //     Написать метод по рассчету средней скорости на участке и выводе сообщения
        // превысил водитель скорость или нет. Метод должен принимать во сколько
        // водитель въехал в участок контроля скорости и время во сколько выехал из
        // участка, в виде HH:MM:SS , длинну учатска контроля скорости и среднюю
        // допустимую скорость участка
        // В задаче использовать необязательные парметры, локальные методы.
        // время въезда+
        // время выезда+
        // длина участка контроля+
        // средняя допустимая скорость+
        static void Task2()
        {
            System.Console.WriteLine("TASK2");
            string? timein = Console.ReadLine();
            string? timeout = Console.ReadLine();
            double lengthroad = Convert.ToDouble(Console.ReadLine());
            if (!string.IsNullOrEmpty(timein) && !string.IsNullOrEmpty(timeout))
            {
                Averagespeed(timein, timeout, lengthroad, out string speedonlengthroadout, out string message);
                System.Console.WriteLine($"{speedonlengthroadout},{message}");
            }
            else
            {
                System.Console.WriteLine("Вы ввели пустоту или налл");
            }
        }
        static string Averagespeed(string timein, string timeout, double lengthroad, out string speedonlengthroadout, out string message, double maxspeed = 110)
        {
            message = "Speed <110";
            double timeitog = 0;
            Timeitogmethod(timein, timeout);
            double speedonlengthroad = lengthroad / (timeitog / 3600);
            if (speedonlengthroad > 110)
            {
                message = "Speed >110";
            }
            double Timeitogmethod(string timein, string timeout)
            {
                string[] timeinarray = timein.Split(":");
                string[] timeoutarray = timeout.Split(":");
                double hh = Convert.ToDouble(timeoutarray[0]) - Convert.ToDouble(timeinarray[0]);
                double mm = Convert.ToDouble(timeoutarray[1]) - Convert.ToDouble(timeinarray[1]);
                double ss = Convert.ToDouble(timeoutarray[2]) - Convert.ToDouble(timeinarray[2]);
                timeitog = hh * 3600 + mm * 60 + ss;
                return timeitog;
            }
            speedonlengthroadout = speedonlengthroad.ToString();
            return speedonlengthroadout;
        }
        #endregion
    }

}



