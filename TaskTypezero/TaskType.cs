﻿// //По навигации, задачу от задачи цифрами отделял, ----------------------  - это отделение от условия и моих пометок, 
// // как я пришёл к какой-то логике, может где-то она неверная, ______________________ - это отделение задачи от задачи.


// //1.Даны переменные a = 10 и b = 3. Найдите остаток от деления a на b.
// // --------------------------------
int a = 10;
int b = 3;
int c = a % b;
Console.WriteLine(c);
// //______________________________________________________________________________________
// // 2. Пользователь вводит с клавиатуры 2 числа: основание степени и показатель
// //степени. Необходимо возвести число во введенную степень

// // P.S. делал 1 способом, но понял что напрямую в степень не возводит порылся в документации 
// // понял, что для того, чтобы возвести в степень, нужно вызвать метод Pow, 
// // прочитал что метод принимает значения типа double, затестил с byte, всё норм
int d = Convert.ToByte(Console.ReadLine());
int e = Convert.ToByte(Console.ReadLine());
int f = d ^ e;
Console.WriteLine(f);
// //----------------------------

byte d1 = Convert.ToByte(Console.ReadLine());
byte e1 = Convert.ToByte(Console.ReadLine());
Console.WriteLine($"{d1}^{e1} = " + Math.Pow(d1, e1));
// //______________________________________________________________________________________

// // 3. Напишите программу, которая считывает длины двух катетов в прямоугольном 
// // треугольнике и выводит его площадь. Используйте формулу
// //S=12∙aa∙b

// //P.S. Так как катеты могут иметь длинну нецелого числа, быть переведены в разные метрические длинны,также площадь
// //может быть не целым числом то логичнее использовать float, понял что лучше double, потому что с флоат не всё одназначно
// // вынес в доп вопросы, потому что с суффиксом не помогло
// // --------------------------------

double g = Convert.ToDouble(Console.ReadLine());
double h = Convert.ToDouble(Console.ReadLine());
double i = 12 * g* g * h;
Console.WriteLine(i);
// //______________________________________________________________________________________

// //4. У известного американского писателя Рэя Бредбери есть роман «451 градус по
// // Фаренгейту». Напишите скрипт, который определяет, какой температуре по
// // шкале Цельсия соответствует указанное значение по шкале Фаренгейта.
// // Используйте формулу :
// // C=5/9∙(F 32)

// //P.S. решил добить float, нашёл и заюзал такое решение, ещё остался вопрос с суффиксом 
// // --------------------------------

float j = Convert.ToSingle(Console.ReadLine());
float k= (5F/9F) * (j-32F);
Console.WriteLine (k);
// //______________________________________________________________________________________

// // 5. Даны переменные a и b. Проверьте, что a делится без остатка на b. Если это так
// // выведите ' и результат деления, иначе выведите 'Делится с и
// // само значение деления

// //P.S. закрепил 4, думаю тут множество вариаций решений в задаче
// // --------------------------------
float l = Convert.ToSingle(Console.ReadLine());
float m = Convert.ToSingle(Console.ReadLine());
float n = (l % m);
float o = (l / m);
if (n == 0)
{
    Console.WriteLine($"Делится, результат деления: {o}");
}
else 
{
    Console.WriteLine($"Делится с остатком, результат деления: {o}, результат остатка {n}");
}
// //______________________________________________________________________________________

// // 6. Вы вводите 2 числа a и b. Вам необходимо решить пример (2(а-b)-4(b-a))/2
// //
// //P.S. потестил парс
// // --------------------------------
double p = Double.Parse(Console.ReadLine());
double r = Double.Parse(Console.ReadLine());
double s = (2*(p-r)-4*(r-p))/2;
Console.WriteLine(s);
// //______________________________________________________________________________________

// // 7. На вход программе подается число n количество собачьих лет. Напишите
// // программу, которая вычисляет возраст собаки в человеческих годах.
// // В течение первых двух лет собачий год равен 10.5 человеческим годам. После
// // этого каждый год собаки равен 4 человеческим годам
// //
// //P.S. добил парс, но convert было бы логичнее
// // --------------------------------
double q = Double.Parse(Console.ReadLine());
if (q < 2)
{
    Console.WriteLine($"{q * 10,5}");
}
else 
{
    double u = (21 + (q - 2) * 4);
    Console.WriteLine($"{u}");
}
// //______________________________________________________________________________________

// //8. Найдите квадратный корень из 245 . Предварительно изучите System. Math и в
// //отдельности Math. Sqrt https:// learn.microsoft.com/ru/dotnet/api/system.math?view=net 7.0
// //
// //P.S. 
// // --------------------------------
Console.WriteLine("Квадратный корень из 245: " + Math.Sqrt(245));

// //______________________________________________________________________________________

// //9.Даны числа 4, 2, 5, 19, 130, 0, 10. Найдите минимальное и максимальное число .
// // Предварительно изучите модуль Math и в отдельности Math.Min и Math.Max
// //
// //P.S. топорный способ, можно потом подумать что-то через if 
// // --------------------------------
Console.WriteLine($"{Math.Max(10,Math.Max(0,Math.Max(130,Math.Max(19,Math.Max(5,Math.Max(4,2))))))}");
Console.WriteLine($"{Math.Min(10,Math.Min(0,Math.Min(130,Math.Min(19,Math.Min(5,Math.Min(4,2))))))}");
// //______________________________________________________________________________________
// //10. Напишите программу, вычисляющую объём куба и площадь его полной
// //поверхности , по введённому значению длины ребра . Используйте формулы
// //V=a2,S=6∙a2
// //
Console.WriteLine(Math.Pow((double)Convert.ToDecimal(Console.ReadLine())),(double)2.0); 
// // --------------------------------

decimal objcuba = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"{objcuba * objcuba}");
Console.WriteLine($"{6*objcuba * objcuba}");
// //______________________________________________________________________________________

// //11.Напишите программу, в которой вычисляется сумма, разность и произведение
// // двух целых чисел, введенных с клавиатуры

int chislo1 = Convert.ToInt32(Console.ReadLine());
int chislo2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{chislo1 + chislo2}");
Console.WriteLine($"{chislo1 - chislo2}");
Console.WriteLine($"{chislo1 * chislo2}");
// //______________________________________________________________________________________

// //12. Напишите программу для пересчёта величины временного интервала, заданного
// // в минутах, в величину, выраженную в часах и минутах
// // Пример
// // 150 => 2 час 30 минут
// // 50 = => 0 час 50 минут
// // 240 = => 4 час 0 минут
// //P.S. 
// // --------------------------------

int minut = Convert.ToInt32(Console.ReadLine());
int chasov = minut / 60;
int ostMin = minut % 60;
Console.WriteLine($"{chasov} час {ostMin} минут");
// //______________________________________________________________________________________