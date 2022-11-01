// // 1. Объявить оперменные и поменять в их значения три раза (string, int, bool, double)
Console.WriteLine("Задача 1");
double peremenya;
double peremenya1;
peremenya1 = 4.0;
peremenya = 2.0;
peremenya = 3.0;
peremenya += 2.0;
peremenya = peremenya1 + peremenya;
peremenya = -peremenya;
// ----------------------------
string peremenya2;
string peremenya3;
peremenya3 = "tr";
peremenya2 = "rt";
peremenya2 = peremenya2 + peremenya3;
peremenya2 += peremenya3;
Console.WriteLine(peremenya2);
Console.WriteLine("конкатенация+: " + peremenya2 + peremenya3);
// ----------------------------
bool peremenya4;
peremenya4 = true;
peremenya4 = !true;
Console.WriteLine(peremenya4);
peremenya4 = true;
Console.WriteLine(peremenya4);
peremenya4 ^= peremenya4;
Console.WriteLine(peremenya4);
// -----------------------
int peremenya10 = 5;
peremenya10++;
++peremenya10;
peremenya10 = peremenya10 + 1;
Console.WriteLine(peremenya10);
//_________________________________________________________
// 2. Произвести все все комбинации неявного преобразования (byte, int, long, float, double, decemel)
Console.WriteLine("Задача 2");
byte peremenya5 = 1;
int peremenya6 = peremenya5;
long peremenya7 = peremenya6;
float peremenya8 = peremenya7;
double peremenya9 = peremenya8;
//_________________________________________________________
// 3. Произвести все все комбинации явного преобразования (byte, int, long, float, double, decemel)
Console.WriteLine("Задача 3");
byte peremenya11 = 1;
int peremenya12 = (int)peremenya11;
long peremenya13 = (long)peremenya12;
float peremenya14 = (float)peremenya13;
double peremenya15 = (double)peremenya14;
decimal peremenya16 = (decimal)peremenya15;
byte peremenya17 = (byte)peremenya16;
//_________________________________________________________
// 4. Ввести два числа, произвести арифметические над числами и записать результат в первое число (+, -, /, *, %)
Console.WriteLine("Задача 4");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
number = number + number2;
number = number - number2;
number = number / number2;
number = number * number2;
number = number % number2;
//_________________________________________________________
// 5. Ввести число и увеличить его на 1 всеми доступными способами
Console.WriteLine("Задача 5");
int chislotask5 = Convert.ToInt32(Console.ReadLine());
int chislo1task5 = 1;
chislotask5 = chislotask5 + 1;
chislotask5++;
++chislotask5;
chislotask5 = chislotask5 + chislo1task5;
chislotask5 += 1;
Console.WriteLine(chislotask5);
//_________________________________________________________
// 6. Ввести строку, если строка число найти остаток от деления на 5, в противном случае вывести 
// сообщение, что введено не число
Console.WriteLine("Задача 6");
string? chislotask6 = Console.ReadLine();
int outnumbertask6;
bool resulttask6 = int.TryParse(chislotask6, out outnumbertask6);
string vyvodtask6 = resulttask6 == true ? $"{outnumbertask6 % 5}" : "введено не число";
Console.WriteLine($"{vyvodtask6}");
// -----------------------
// 2 способ
Console.WriteLine("Задача 6");
string? chislo1task6 = Console.ReadLine();
int outnumber1task6;
bool result1task6 = int.TryParse(chislo1task6, out outnumber1task6);
string vyvod1task6 = result1task6 == true ? $"{outnumber1task6 % 5}" : "введено не число";
Console.WriteLine($"{vyvod1task6}");

//_________________________________________________________
// 7. Ввести две строки, если строки числа вывести их сумму, в противном случае вывести сообщение какие строки не являются числом
Console.WriteLine("Задача 7");
string? chislo1 = Console.ReadLine();
string? chislo2 = Console.ReadLine();
int outnumber;
int outnumber1;
if (int.TryParse(chislo1, out outnumber) && int.TryParse(chislo2, out outnumber1))
{
    Console.WriteLine(outnumber + outnumber1);
}
else if (int.TryParse(chislo1, out outnumber))
{
    Console.WriteLine("chislo2 - не число");
}
else if (int.TryParse(chislo2, out outnumber1))
{
    Console.WriteLine("chislo1 - не число");
}
else
{
    Console.WriteLine("chislo1 - не число,chislo2 - не число");
}
//_________________________________________________________
// 8. Ввести два числа, если 1 число больше 2, то произвести деление 1 на 2, если 2 больше 1 вывести
// разность между 2 и 1, в противном случае вернуть 0.0 и результат увеличить на 10 (if-else, тернаный оператор)
Console.WriteLine("Задача 8");
double er = Convert.ToDouble(Console.ReadLine());
double er1 = Convert.ToDouble(Console.ReadLine());
double otvet = er == er1 ? 0.0 + 10 : er > er1 ? er / er1 : er1 - er;
Console.WriteLine(Math.Round(otvet, 2));
//_________________________________________________________
// 9. Ввести две строки, если две строки числа то ввести арифметический оператор, b в зависисмоти от арфметического 
// оператора произвести то действие в проитивных случаях произвести вывод сообщений. Сделать проверку на null 
// оператора (if-else, switch, (-)сокращенный switch)
Console.WriteLine("Задача 9");
string? str = Console.ReadLine();
string? str1 = Console.ReadLine();
int irt;
int irt1;
if (int.TryParse(str, out irt) && int.TryParse(str1, out irt1))
{
    string? oper = Console.ReadLine();
    if (!String.IsNullOrEmpty(oper))
    {
        switch (oper)
        {
            case "+":
                Console.WriteLine(irt + irt1);
                break;
            case "-":
                Console.WriteLine(irt - irt1);
                break;
            case "/":
                Console.WriteLine(irt / irt1);
                break;
            case "*":
                Console.WriteLine(irt * irt1);
                break;
            case "%":
                Console.WriteLine(irt % irt1);
                break;
            case "!":
                Console.WriteLine(irt != irt1);
                break;
        }
    }
    else { Console.WriteLine("Строка оператор null или empty"); }
}
else { Console.WriteLine("Одна из строк is not число"); }
//_________________________________________________________
// 10. Ввести две строку и произвести сложение данных строк всеми известными способами
Console.WriteLine("Задача 10");
string? linestroka1 = Console.ReadLine();
string? linestroka2 = Console.ReadLine();
linestroka1 = linestroka1 + linestroka2;
Console.WriteLine($"{linestroka1}");
linestroka1 += linestroka2;
Console.WriteLine($"{linestroka1}");
Console.WriteLine($"{linestroka1 + linestroka2}");
//_________________________________________________________
// // 11. Ввести строку до 5 символов, если строка число то вывести для кажкой цифры в числе кратно 
// // оно двум либо нет, то есть 6352 => 6 крастно двум, 3 не кратно двум, 5  не кратно двум, 2 
// // // крастно двум (if-else, тернаный оператор)

Console.WriteLine("Задача 11");
string? yu = Console.ReadLine();

if (yu.Length < 5 && int.TryParse(yu, out int strokachislo) && !(yu == null) && strokachislo > 999)

{
    int tysach = strokachislo / 1000;
    int sotnya = strokachislo / 100 - tysach * 10;
    int desytok = strokachislo / 10 - tysach * 100 - sotnya * 10;
    int edinicy = strokachislo / 1 - tysach * 1000 - sotnya * 100 - desytok * 10;
    if (tysach % 2 == 0)
    {
        string sttysach = $"{tysach}-кратно двум";
    }
    else
    {
        Console.WriteLine($"{tysach}-не кратно двум");
    }
    if (sotnya % 2 == 0)
    {
        Console.WriteLine($"{sotnya}-кратно двум");
    }
    else
    {
        Console.WriteLine($"{sotnya}-не кратно двум");
    }
    if (desytok % 2 == 0)
    {
        Console.WriteLine($"{desytok}-кратно двум");
    }
    else
    {
        Console.WriteLine($"{desytok}-не кратно двум");
    }
    if (edinicy % 2 == 0)
    {
        Console.WriteLine($"{edinicy}- кратно двум");
    }
    else
    {
        Console.WriteLine($"{edinicy}-не кратно двум");
    }
}
else if (yu.Length < 5 && int.TryParse(yu, out strokachislo) && !(yu == null) && strokachislo > 99)
{
    int sotnya = strokachislo / 100;
    int desytok = strokachislo / 10 - sotnya * 10;
    int edinicy = strokachislo / 1 - sotnya * 100 - desytok * 10;
    if (sotnya % 2 == 0)
    {
        Console.WriteLine($"{sotnya}-кратно двум");
    }
    else
    {
        Console.WriteLine($"{sotnya}-не кратно двум");
    }
    if (desytok % 2 == 0)
    {
        Console.WriteLine($"{desytok}-кратно двум");
    }
    else
    {
        Console.WriteLine($"{desytok}-не кратно двум");
    }
    if (edinicy % 2 == 0)
    {
        Console.WriteLine($"{edinicy}- кратно двум");
    }
    else
    {
        Console.WriteLine($"{edinicy}-не кратно двум");
    }
}
else if (yu.Length < 5 && int.TryParse(yu, out strokachislo) && !(yu == null) && strokachislo > 9)

{
    int desytok = strokachislo / 10;
    int edinicy = strokachislo / 1 - desytok * 10;
    if (desytok % 2 == 0)
    {
        Console.WriteLine($"{desytok}-кратно двум");
    }
    else
    {
        Console.WriteLine($"{desytok}-не кратно двум");
    }
    if (edinicy % 2 == 0)
    {
        Console.WriteLine($"{edinicy}- кратно двум");
    }
    else
    {
        Console.WriteLine($"{edinicy}-не кратно двум");
    }
}
else if (yu.Length < 5 && int.TryParse(yu, out strokachislo) && !(yu == null) && strokachislo >= 0)

{
    int edinicy = strokachislo / 1;
    if (edinicy % 2 == 0)
    {
        Console.WriteLine($"{edinicy}- кратно двум");
    }
    else
    {
        Console.WriteLine($"{edinicy}-не кратно двум");
    }
}
else if (yu.Length > 5 && int.TryParse(yu, out strokachislo) == true)
{ Console.WriteLine("Вы ввели число больше 9999, введите меньше"); }
else { Console.WriteLine("Вы ввели не число"); }

//-----------------------------------------------------------
// вариант 2 (не до конца доведённый)
// if (yu.Length < 5)
// {
//     if (int.TryParse(yu, out int strokachislo))
//     {
//         if (((Convert.ToInt32(yu[0]) % 2) != 0))
//         {
//             chifra1 = ($"{yu[0]}, некратно двум");
//         }
//         else if ((yu[1] % 2 != 0))
//         {
//             chifra2 = ($"{yu[1]}, некратно двум");
//         }
//         else if ((yu[2] % 2 != 0))
//         {
//             chifra3 = ($"{yu[2]}, некратно двум");
//         }
//         else if ((yu[3] % 2 != 0))
//         {
//             chifra4 = ($"{yu[3]}, некратно двум");
//         }
//         else if ((yu[0] % 2 == 0))
//         {
//             chifra1 = ($"{yu[0]}, кратно двум");
//         }
//         else if ((yu[1] % 2 == 0))
//         {
//             chifra2 = ($"{yu[1]}, кратно двум");
//         }
//         else if ((yu[2] % 2 == 0))
//         {
//             chifra3 = ($"{yu[2]}, кратно двум");
//         }
//         else if ((yu[3] % 2 == 0))
//         {
//             chifra4 = ($"{yu[3]}, кратно двум");
//         }
//     }
//     // (yu[0] % 2 == 0 && yu[1] % 2 == 0 && yu[2] % 2 == 0 && yu[3] % 2 == 0) { Console.WriteLine($"{yu[0]} кратно 2, {yu[1]} кратно 2, {yu[2]} кратно 2, {yu[3]} кратно 2");
//     // Console.WriteLine($"{yu[0]}+{yu[1]}");
//     else { Console.WriteLine("Нужно ввести число"); }
// }
// else { Console.WriteLine("Нужно ввести строку до 5 символов"); }
// Console.WriteLine($"{chifra1},{chifra2},{chifra3},{chifra4}");
// Console.WriteLine($"{chifra1}");
// Console.WriteLine($"{chifra2}");
// Console.WriteLine($"{chifra3}");
// Console.WriteLine($"{chifra4}");
// int iu = Convert.ToInt32(yu[0]) % 2;
// Console.WriteLine(iu);
//-----------------------------------------------------------
// вариант 3 (не до конца доведённый)

// Console.WriteLine("Задача 11");
// string? yu = Console.ReadLine();
// string resulttysach = "";
// string resultsotnya = "";
// string desatki = "";
// string chislo = "";

// if (yu.Length < 5 && int.TryParse(yu, out int strokachislo) && !(yu == null))
// {

//     int tysach = strokachislo / 1000;
//     int sotnya = strokachislo / 100 - tysach * 10;
//     int desytok = strokachislo / 10 - tysach * 100 - sotnya * 10;
//     int edinicy = strokachislo / 1 - tysach * 1000 - sotnya * 100 - desytok * 10;
//     if (strokachislo > 999)
//     {
//         { resulttysach = (strokachislo / 1000) % 2 == 0 ? "Кратно двум" : "не кратно двум"; }
//     }
//     if (strokachislo > 99)
//     {
//         { resultsotnya = ((strokachislo % 1000)/100)%2 == 0 ? "Кратно двум" : "не кратно двум"; }
//     }
//     Console.WriteLine($"{tysach}-{resulttysach},{sotnya}-{resultsotnya}");
// }
//_________________________________________________________
// 12. Ввести две строки, произвести проврку на пустоту, если строки имеют символы то если первая строка больше
//  второй вывести сумму длин строк, в противном случае разность 2 от первой 
//  (if-else, (-)тернаный оператор, *.Length, string.IsNullorEmpty)
// -------------
Console.WriteLine("Задача 12");
string? line1 = Console.ReadLine();
string? line2 = Console.ReadLine();
if (!String.IsNullOrEmpty(line1))
{
    if (!String.IsNullOrEmpty(line2))
    {
        if (line1.Length >= line2.Length)
        { Console.WriteLine(line1.Length + line2.Length); }
        else
        { Console.WriteLine(line2.Length - line1.Length); }
    }
    else
    { Console.WriteLine("Строка line2 null или empty"); }
}
else
{
    Console.WriteLine("Строка line1 null или empty");
}
//_________________________________________________________