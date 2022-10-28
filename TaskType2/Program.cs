// // 1.Найти максимальное число из 2 введенных (2 способа)
// //-------------------------------------------------
int chis = Convert.ToInt32(Console.ReadLine());
int chis1 = Convert.ToInt32(Console.ReadLine());
if (chis > chis1)
{
    Console.WriteLine("1 число максимальное из 2 введённых");
}
else if (chis == chis1)
{
    Console.WriteLine("1 число равно 2");
}
else
{
    Console.WriteLine("2 число максимальное из 2 введённых");
}



// //-------------------------------------------------
int chis2 = Convert.ToInt32(Console.ReadLine());
int chis3 = Convert.ToInt32(Console.ReadLine());
int chis4 = Math.Max(chis2, chis3);
Console.WriteLine($"{chis4}");

// //_______________________________________________________________
// // 2. Выявить является ли введенное число четным
// //-------------------------------------------------
int chet = Convert.ToInt32(Console.ReadLine());
switch (chet)
{
    case >= 0 when chet % 2 == 0:
        System.Console.WriteLine("Число чётное");
        break;
    case > 0 when chet % 2 != 0:
        System.Console.WriteLine("Число нечётное");
        break;
}
// //----------------------------
int chet1 = Convert.ToInt32(Console.ReadLine());
string result = chet switch
{
    >= 0 when chet1 % 2 == 0 => "Число чётное",
    > 0 when chet1 % 2 != 0 => "Число нечётное",
    < 0 when chet1 % 2 == 0 => "Число чётное",
    < 0 when chet1 % 2 != 0 => "Число нечётное",
};
System.Console.WriteLine(result);
// //_______________________________________________________________

// // 3.
// // Пользователь вводит число от 1 до 7, соответствующее дню недели. Необходимо
// // вывести день для введенного числа.
// // 1 --> Понедельник

int dennedelya = Convert.ToInt32(Console.ReadLine());
if (dennedelya == 1)
{
    Console.WriteLine($"{dennedelya} --> Понедельник");
}
else if (dennedelya == 2)
{
    Console.WriteLine($"{dennedelya} --> Вторник");
}
else if (dennedelya == 3)
{
    Console.WriteLine($"{dennedelya} --> Среда");
}
else if (dennedelya == 4)
{
    Console.WriteLine($"{dennedelya} --> Четверг");
}
else if (dennedelya == 5)
{
    Console.WriteLine($"{dennedelya} --> Пятница");
}
else if (dennedelya == 6)
{
    Console.WriteLine($"{dennedelya} --> Суббота");
}
else if (dennedelya == 7)
{
    Console.WriteLine($"{dennedelya} --> Воскресенье");
}
// //---------------------------- 
int dennedelya1 = Convert.ToInt32(Console.ReadLine());
switch (dennedelya1)
{
    case 1:
        System.Console.WriteLine($"{dennedelya1} -->Понедельник");
        break;
    case 2:
        System.Console.WriteLine($"{dennedelya1} -->Вторник");
        break;
    case 3:
        System.Console.WriteLine($"{dennedelya1} -->Среда");
        break;
    case 4:
        System.Console.WriteLine($"{dennedelya1} -->Четверг");
        break;
    case 5:
        System.Console.WriteLine($"{dennedelya1} -->Пятница");
        break;
    case 6:
        System.Console.WriteLine($"{dennedelya1} --> Суббота");
        break;
    case 7:
        System.Console.WriteLine($"{dennedelya1} --> Воскресенье");
        break;
}
// //_______________________________________________________________
// //4. Есть строка в 3 символа. Написать проверку если число, вывести true, в
// противном случае false Char.IsDigit (str2, position))
var str = Console.ReadLine();
int str1;
bool proverka = int.TryParse(str, out str1);
switch (proverka)
{
    case true:
        System.Console.WriteLine($"{str} Это число");
        break;
    case false:
        System.Console.WriteLine("false Char.IsDigit (str2, position) - Это строка");
        break;
}
// //------------------------
var str2 = Console.ReadLine();
int str3;
bool proverka1 = int.TryParse(str2, out str3);
var result1 = proverka1 switch
{
    true => $"{str2} Это число",
    false => "false Char.IsDigit (str2, position)- Это строка"
};
System.Console.WriteLine(result1);
// //------------------------
var str4 = Console.ReadLine();
bool proverka2 = Char.IsDigit(str4, 0);
switch (proverka2)
{
    case true:
        System.Console.WriteLine($"{str4} Это число");
        break;
    case false:
        System.Console.WriteLine("false Char.IsDigit (str4, 0 position)- Это строка");
        break;
}
// //_______________________________________________________________

// // 5. Пользователь вводит число с клавиатуры. Нужно вывести на экран сколько в этом
// // числе цифр, а также положительное оно или отрицательное. Например, 
// // "Число " + num + " однозначное положительное". (Length)

var schetkolich = Console.ReadLine();
int schetkolich1 = schetkolich.Length;
int nachislo;
bool proverka51 = int.TryParse(schetkolich, out nachislo);
switch (nachislo)
{
    case (> 0):
        System.Console.WriteLine("Число " + nachislo + " однозначное положительное." + $" Его длинна: {schetkolich1}");
        break;
    case (< 0):
        System.Console.WriteLine("Число " + nachislo + " однозначное отрицательное." + $" Его длинна: {schetkolich1}");
        break;
    case 0:
        System.Console.WriteLine("Число " + nachislo + " однозначное Ноль))))." + $" Его длинна: {schetkolich1}");
        break;
}
// //------------------------------------------------------------------------
var schetkolich2 = Console.ReadLine();
int schetkolich3 = schetkolich2.Length;
int nachislo1;
bool proverka52 = int.TryParse(schetkolich2, out nachislo1);
string itog = nachislo1 switch 
{
    > 0 => "Число " + nachislo1 + " однозначное положительное." + $" Его длинна: {schetkolich3}",
   < 0 => "Число " + nachislo1 + " однозначное отрицательное." + $" Его длинна: {schetkolich3-1}",
    0 => "Число " + nachislo1 + " однозначное Ноль))))." + $" Его длинна: {schetkolich3}"
};
System.Console.WriteLine(itog);
// //_______________________________________________________________

// // 6. Найти квадратный корень числа. Если же число без плавающей точки, то просто
// // вывести его. В противном случае необходимо округлить число до целых.
// // Добавить проверку на ввод только чисел
var schetkvkoren = Console.ReadLine();
int schetkvkoren2 = Convert.ToInt32(schetkvkoren);
string schetkvkoren3 = Convert.ToString(Math.Sqrt(schetkvkoren2));
int qw;
bool know = int.TryParse(schetkvkoren3, out qw);
switch (know)
{
    case true:
        System.Console.WriteLine(schetkvkoren3);
        break;
    case false:
        System.Console.WriteLine(Math.Round(Math.Sqrt(schetkvkoren2),2));
        break;
}
// //------------------------------------------------------------------------
var schetkvkoren4 = Console.ReadLine();
int schetkvkoren5 = Convert.ToInt32(schetkvkoren4);
string schetkvkoren6 = Convert.ToString(Math.Sqrt(schetkvkoren5));
int qw1;
bool know1 = int.TryParse(schetkvkoren6, out qw1);
string itogovy = know1 switch
{
    true => schetkvkoren6,
    false => Convert.ToString(Math.Round(Math.Sqrt(schetkvkoren5),2))
};
System.Console.WriteLine(itogovy);
// // 7. Два автомобиля едут друг к другу с постоянными скоростями V1 и V2 км/ч.
// // Определите, через какое время автомобили встретятся , если расстояние между
// // ними равно S км. Добавить проверку на ввод только чисел

string skorost = Console.ReadLine();
double skorostproverka;
bool truefalsechislo = double.TryParse(skorost, out skorostproverka);
string skorost1 = Console.ReadLine();
double skorostproverka1;
bool truefalsechislo1 = double.TryParse(skorost1, out skorostproverka1);
string rastoynie = Console.ReadLine();
double rastoynieproverka1;
bool truefalsechislo2 = double.TryParse(rastoynie, out rastoynieproverka1);
switch (truefalsechislo)
{
    case true:
        switch (truefalsechislo1)
        {
            case true:
                switch (truefalsechislo2)
                {
                    case true:

                        System.Console.WriteLine(rastoynieproverka1 / (skorostproverka1 + skorostproverka));
                        break;
                    case false:
                        System.Console.WriteLine("Расстояние - не число");
                        break;
                }
                break;
            case false:
                System.Console.WriteLine("Скорость 2 - не число");
                break;
        }
        break;
    case false:
        System.Console.WriteLine("Скорость 1 - не число");
        break;
}

// // 8. Пользователь вводит номер месяц. Необходимо вывести пору года по номеру
// // месяца (2 способа)
Console.WriteLine("Задача 8");
int numbermounths = Convert.ToInt32(Console.ReadLine());
if (1 <= numbermounths && numbermounths <= 2 || numbermounths == 12)
{
    Console.WriteLine("Зима");
}
if (3 <= numbermounths && numbermounths <= 5)
{
    Console.WriteLine("Весна");
}
if (6 <= numbermounths && numbermounths <= 8)
{
    Console.WriteLine("Лето");
}
if (9 <= numbermounths && numbermounths <= 11)
{
    Console.WriteLine("Осень");
}
// 2 вариант
Console.WriteLine("Задача 8, 2 способ");
int numbermounths1 = Convert.ToInt32(Console.ReadLine());

switch (numbermounths1, numbermounths1, numbermounths1)
{
    case (1, 2, 12):
        System.Console.WriteLine("Зима");
        break;
    case (3, 4, 5):
        System.Console.WriteLine("Весна");
        break;
    case (6, 7, 8):
        System.Console.WriteLine("Лето");
        break;
    case (9, 10, 11):
        System.Console.WriteLine("Осень");
        break;
}

//9 Пользователь вводит число: 1, 2, 3 или 4. Если это значение ‘2', то вывести в
// // консоль 'зима близко', ‘3' зима, ‘4' всё' . Решите задачу через switch case .
int zimablizko = Convert.ToInt32(Console.ReadLine());
switch (zimablizko)
{
    case (1):
        System.Console.WriteLine("");
        break;
    case (2):
        System.Console.WriteLine("зима близко");
        break;
    case (3):
        System.Console.WriteLine("зима");
        break;
    case (4):
        System.Console.WriteLine("всё");
        break;
}
// // 10. Пользователь вводит одно число. Необходимо вывести обратное ему (число
// //является обратным при 1 / x). Если при этом введённое с клавиатуры число ноль,
// // то вывести «Обратного числа не существует».
double obratnoychislo = Convert.ToDouble(Console.ReadLine());
if (obratnoychislo==0)
{
    Console.WriteLine("Обратного числа не существует");
}
else 
{
    Console.WriteLine(1/obratnoychislo);
}

// // 11 Напишите программу, которая находит полное число метров по заданному числу
// // сантиметров. Добавить проверку на ввод только чисел
// // 345 --> 3
// // 100 --> 1
string? kolichestvometrov = Console.ReadLine();
int.TryParse(kolichestvometrov, out int kolmetr);
Console.WriteLine(kolmetr/100);

// 14.Пользователь вводит 2 числа от 0 до 10. Сложите переменные так, чтобы в
// результате получилось выражение: “I’m хх". Проверки на ввод только чисел.
// Проверки на ввод чисел до 10. Если первое число 0, то опустить его
Console.WriteLine("введите первое число");
string? numberFirst = Console.ReadLine();
Console.WriteLine("введите первое число");
string? numberSecond = Console.ReadLine();
if (int.TryParse(numberFirst, out int number1) && int.TryParse(numberSecond, out int number2))
{
    if (number1 >= 0 && number1 <= 10 && number2 >= 0 && number2 <= 10)
    {
        if (number1 == 0)
        {
            Console.WriteLine($"I'm {number2}");
        }
        else
        {
            Console.WriteLine($"I'm {number1}{number2}");
        }
    }
    else
    {
        Console.WriteLine("вы ввели число не от 0 до 10");
    }
}
else
{
    Console.WriteLine("вы ввели не числа");
}

// // //______________________________________________________________________________________________________________________________
// // // 15.
// // // Пользователь вводит строку. Необходимо сделать проверку, что это не число и
// // // вывести длину строки

Console.WriteLine("Введите строку ");
string? text22 = Console.ReadLine();
if (!int.TryParse(text22, out _)) // "_"- игнорируем объявление переменной
{
    if (!string.IsNullOrEmpty(text22)) //(text != null) "" // string.IsNullOrEmpty(text)) - проверяет на налл и пустое значение
    {
        Console.WriteLine($"Длинна строки {text22.Length} ");
    }
    else
    {
        Console.WriteLine("Пустота");
    }
}
else
{
    Console.WriteLine("ввели число");
}
// //------------------------------------------------------------------------
Console.WriteLine("Введите строку ");
string? text23 = Console.ReadLine();
if (!int.TryParse(text23, out _)) // "_"- игнорируем объявление переменной
{
    string result234 = !string.IsNullOrEmpty(text23) ?  $"Длинна строки {text23.Length} " : "Пустота";
    Console.WriteLine(result234);
}
else
{
    Console.WriteLine("ввели число");
}
// //______________________________________________________________________________________________________________________________

// 16. Пользователь вводит строку. Вывести первый символ строки (индексы)
string? funf = Console.ReadLine();
Console.WriteLine(funf[0]);
// //______________________________________________________________________________________________________________________________

//18.Пользователь вводит строку. Необходимо повторить ее трижды


// 19.Ввести строку. Проверить является ли это число или текст. Если число, то
// выяснить, четное или нет. Если это текст и равен “hschool ”, вывести true. В
// противном случае false
string? funfy = Console.ReadLine();
int funfynumber;
if (int.TryParse(funfy, out funfynumber))
{
    if (funfynumber % 2 == 0)
    {
        Console.WriteLine ("Число Чёткое");
    }
    else {Console.WriteLine ("Число НЕЧёткое");}
}
else 
{
    if(funfy=="hschool")
    {Console.WriteLine (true);}
    else {Console.WriteLine (false);}
}