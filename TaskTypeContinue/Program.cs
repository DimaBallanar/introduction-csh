// // 1. Вы вводите значение с клавиатуры. Если значение равно 0, то вывести ‘Ноль’,
// // если < 0, то вывести ‘Отрицательное’, если > 0, то вывести ‘Положительное’
// // P.S. vyvod = (flower < 0 ) ? "Отрицательное" : (flower > 0 ) ? "Положительное" : "0"; можно ли 0 вывести с WriteLine???
// // --------------------------------
int flower = Convert.ToInt32(Console.ReadLine());
if (flower < 0)
{
    Console.WriteLine("Отрицательное");
}
else if (flower == 0)
{
    Console.WriteLine($"{flower}");
}
else
{
    Console.WriteLine("Положительное");
}
// // ---------------------------- 


int rt = Convert.ToInt32(Console.ReadLine());
string vyvod;
vyvod = (rt < 0) ? "Отрицательное" : (rt > 0) ? "Положительное" : "0";
Console.WriteLine(vyvod);

// // _____________________________________________
// // 2. Вы вводите значение с клавиатуры. Если значение четное, то вывести true, в
// // противном случае false
// // P.S. 
// // // --------------------------------
int qwerty = Convert.ToInt32(Console.ReadLine());
qwerty = qwerty % 2;
if (qwerty == 0)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}
// // --------------------------------
int qwerty2 = Convert.ToInt32(Console.ReadLine());
bool qwertyvyvod;
qwerty2 = qwerty2 % 2;
qwertyvyvod = qwerty2 == 0 ? true : false;
Console.WriteLine(qwertyvyvod);
// // _____________________________________________
// // 3. Пользователь вводит с клавиатуры число. Найдите корень введенного числа
// // (если же результат число с плавающей точкой, то округлить до 2 знаков после
// // запятой
int chislo = Convert.ToInt32(Console.ReadLine());
var chislo1 = Math.Sqrt(chislo);
if (chislo1 % 1 == 0)
{
    Console.WriteLine($"{chislo1}");
}
else
{
    Console.WriteLine($"{Math.Round(chislo1, 2)}");
}
// // --------------------------------
int chisloternarny = Convert.ToInt32(Console.ReadLine());
double chislo1ternarny = Math.Sqrt(chisloternarny);
double chislo1ternarny1 = chislo1ternarny % 1;
chislo1ternarny = chislo1ternarny1 == 0 ? chislo1ternarny : Math.Round(chislo1ternarny, 2);

Console.WriteLine($"{chislo1ternarny}");

// //4. Пользователь вводит с клавиатуры 2 числа: a и b. Проверьте, что a делится без
// // остатка на b. Если это так выведите 'Делится' и результат деления, иначе
// // выведите 'Делится с остатком' и остаток от деления

double opi = Convert.ToDouble(Console.ReadLine());
double opi1 = Convert.ToDouble(Console.ReadLine());
double opi2 = opi % opi1;
double opi3 = opi / opi1;
if (opi2 == 0)
{
    Console.WriteLine($"Делится, результат деления: {opi3}");
}
else
{
    Console.WriteLine($"Делится с остатком, остаток от деления: {opi2}");
}
// // // --------------------------------
// // Тут не знал как
// // double opiternarny = Convert.ToDouble(Console.ReadLine());
// // double opi1ternarny = Convert.ToDouble(Console.ReadLine());
// // double opi2ternarny = opiternarny % opi1ternarny;
// // double opi3ternarny = opiternarny / opi1ternarny;
// // double opi4ternarny;
// // opi4ternarny = opi2ternarny == 0 ? opi3ternarny : opi2ternarny;

// // Console.WriteLine($"{opi4ternarny}");

// // string opi6ternarny = Convert.ToString($"Делится с остатком, остаток от деления: {opi2ternarny}");
// // string opi5ternarny = Convert.ToString($"Делится, результат деления: {opi3ternarny}");

// // 5. Пользователь вводит с клавиатуры число. Найдите корень введенного числа
// // (если же результат число с плавающей точкой, то округлить то целых)
double five = Convert.ToDouble(Console.ReadLine());
five = Math.Sqrt(five);
if (five % 1 == 0)
{
    Console.WriteLine($"{five}");
}
else
{
    Console.WriteLine($"{Math.Round(five)}");
}
// // // --------------------------------
double fiveternarny = Convert.ToDouble(Console.ReadLine());
fiveternarny = Math.Sqrt(fiveternarny);
double fiveternarny1 = fiveternarny % 1;
fiveternarny = fiveternarny1 == 0 ? fiveternarny : Math.Round(fiveternarny);
Console.WriteLine($"{fiveternarny}");
// // _____________________________________________

// // 6. Даны три числа a, b, c. Напишите программу, которая находит корни квадратного
// // уравнения
// // ax2+ bx + c = 0
// // Если
// // уравнение имеет два корня, то следует вывести их в порядке возрастания.

double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
double iks;
double iks1;
double iks2;
double iks3;
double d = Math.Pow(b, 2) - 4 * a * c;
Console.WriteLine($"{d}");
if (d > 0)
{
    iks = (-b - Math.Sqrt(d)) / 2 * a;
    iks1 = (-b + Math.Sqrt(d)) / 2 * a;
    iks2 = Math.Max(iks, iks1);
    iks3 = Math.Min(iks, iks1);
    Console.WriteLine($"{iks3},    {iks2}");
}
else if (d == 0)
{
    iks = (-b - Math.Sqrt(d)) / 2 * a;
    Console.WriteLine($"{iks}");
}
else
{
    Console.WriteLine("Разошлись мирно, корней - нет");
}
// // _____________________________________________
// // 7.Пользователь вводит число от 1 до 9999 (сумму выдачи в банкомате). Необходимо
// // вывести на экран словами введенную сумму и в конце написать название валюты
// // с правильным окончанием. Например: 7431 - семь тысяч четыреста тридцать один
// // доллар, 2149-  две тысячи сто сорок девять долларов , 15-пятнадцать долларов , 3-доллара
// // 1,21,31,41,51,61,71,81,91 - доллар
// // 2,3,4,22-24 - доллара
// // 5,6,7,8,9,10,11-20,25-30 - долларов

// // _____________________________________________

// // 8. Пользователь вводит порядковый номер пальца руки. Необходимо показать его
// // название на экран
int palec = Convert.ToInt32(Console.ReadLine());
if (palec == 1)
{
    Console.WriteLine("Большой палец");
}
else if (palec == 2)
{
    Console.WriteLine("Указательный палец");
}
else if (palec == 3)
{
    Console.WriteLine("Средний палец");
}
else if (palec == 4)
{
    Console.WriteLine("Безымянный палец");
}
else if (palec == 5)
{
    Console.WriteLine("Мизинец");
}

int palecternary = Convert.ToInt32(Console.ReadLine());
string palecvyvod;
palecvyvod = (palecternary == 1) ? "Большой палец" : (palecternary == 2) ? "Указательный палец" : (palecternary == 3) ? "Средний палец" : (palecternary == 4) ? "Безымянный палец" : "Мизинец";
Console.WriteLine(palecvyvod);
// // _____________________________________________
// // 9. Необходимо написать программу, которая проверяет пользователя на знание
// // таблицы умножения. Пользователь сам вводит два целых однозначных числа.
// // Программа задаёт вопрос: результат умножения первого числа на
// // второе. Пользователь должен ввести ответ и увидеть на экране правильно он
// // ответил или нет. Если нет показать еще и правильный результат
int ymnoz = Convert.ToInt32(Console.ReadLine());
int ymnoz1 = Convert.ToInt32(Console.ReadLine());
int ymnoz2 = ymnoz * ymnoz1;
Console.Write("Введите результат умножения первого числа на второе: ");
int ymnoz3 = Convert.ToInt32(Console.ReadLine());
if (ymnoz2 == ymnoz3)
{
    Console.WriteLine("Верный ответ");
}
else
{
    Console.WriteLine($"Неверный ответ, верный ответ: {ymnoz2}");
}
// // _____________________________________________
// // 10.
// // Пользователь вводит два числа, если хотя бы одно число равно 0 то необходимо
// // получить битовую инверсию числа не равного 0, +
// // если первое число больше 20,+
// // необходимо найти остаток от делания большего на меньшее, +
// // если второе меньше+
// // 0 найти модуль целой часть от деления первого числа на второе+, если первое и+
// // второе числа чётные найти логическое битовое И для двух чисел, в противном 
// // случае логическое битовое ИЛИ. 
// Для полученного результата произвести
// // битовый сдвиг который укажет пользователь, если сдвиг четный, то сдвиг вправо,
// // если нечетный влево. Полученный результат вывести на экран
{
    Console.WriteLine("Введите первое число");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int result;
    if (number1 == 0 || number2 == 0)
    {
        //необходимо получить битовую инверсию числа не равного 0
        if (number1 == 0)
        {
            result = ~number2;
            Console.WriteLine(result);
        }
        else
        {
            result = ~number1;
            Console.WriteLine(result);
        }
    }
    else if (number1 > 20) //если первое больше 20, то найти остаток от деления большего на меньшее
    {
        if (number1 > number2) //необходимо найти остаток от деления большего на меньшее
        {
            result = number1 % number2;
            Console.WriteLine($"Остаток от деления большего числа на меньшее: {result} ");
        }
        else
        {
            result = number2 % number1;
            Console.WriteLine($"Остаток от деления большего числа на меньшее: {result} ");
        }
    }
    else if (number2 < 0)//если второе меньше 0
    {
        // найти модуль целой часть от деления первого числа на второе
        result = Math.Abs(number1 / number2);
        Console.WriteLine($"Модуль целой части от деления первого числа на второе: {result} ");
    }
    else if (number1 % 2 == 0 && number2 % 2 == 0) // если четные найти логическое битовое И, а если нечетные то ИЛИ
    {
        result = number1 & number2;
        Console.WriteLine(Convert.ToString(result, toBase: 2));
    }
    else
    {
        result = number1 | number2;
        Console.WriteLine(Convert.ToString(result, toBase: 2));
    }

    Console.WriteLine("Введите битовый сдвиг");
    int shift = Convert.ToInt32(Console.ReadLine());
    if (shift % 2 == 0)
    {
        Console.WriteLine(result >> shift);
    }
    else if (shift % 2 == 1)
    {
        Console.WriteLine(result << shift);
    }
}