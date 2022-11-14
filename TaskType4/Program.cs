// 1.
// Ввести строку. Если эта равна “hschool”, вывести true. В противном случае false.
// Добавить проверки для строк . Удалить лишние пробелы
Console.WriteLine("Задача 1");
string? stroka = Console.ReadLine();
if (!string.IsNullOrEmpty(stroka))
{
    Console.WriteLine(stroka.ToLower().Trim() == "hschool");
}
else { Console.WriteLine("Вы ввели пустую строку"); }
// ______________________________________________________________________
// 2.Ввести строку. Проверить является ли это число или строка. Если число, то
// выяснить, четное или нет. Если это строка то преобразовать строку в массив, где
// каждый символ один элемент массива hschool ’ => [‘h’, ‘s’, ‘c’, ‘h’, ‘o’, ‘o’, ‘l’]
Console.WriteLine("Задача 2");
string? text = Console.ReadLine();
if (!string.IsNullOrEmpty(text))
{
    if (double.TryParse(text, out double number))
    {
        Console.WriteLine(number % 2 == 0 ? "чётное" : "не чётное");
    }
    else
    {
        string[] result = text.Split(".");
        Console.WriteLine(result.Length);
    }
}
// ______________________________________________________________________
// 3.Преобразовать строку ‘Full с StaCK DevELoper в массив вида [‘full’, ‘stack’,
// ‘developer’]
Console.WriteLine("Задача 3");
string textUser = "Full сStaCK DevELoper";
textUser = textUser.ToLower();
string[] result1 = textUser.Split(' ');
System.Console.WriteLine(result1[0]);
System.Console.WriteLine(result1[1]);
System.Console.WriteLine(result1[2]);
// ______________________________________________________________________
// 4. Ввести строку. Проверить на isNaN . Если число, то ошибка ввода. Если это строка
// то узнать какая у нее длина. Привести к одному регистру, убрать лишние пробелы
Console.WriteLine("Задача 4");
string? strokatt4 = Console.ReadLine();
if (!string.IsNullOrEmpty(strokatt4) && !int.TryParse(strokatt4, out _))
{
    Console.WriteLine(strokatt4.Length);
    Console.WriteLine(strokatt4.Trim().ToUpper());
}
else
{
    Console.WriteLine("Вы ввели число или пустую строку");
}
// ______________________________________________________________________
// 5.‘HTML JavaScript PHP’ преобразовать в "HTML-JAVASCRIPT-PHP"
Console.WriteLine("Задача 5 - 1 способ");
string newstrokatt5 = "HTML JavaScript PHP";
Console.WriteLine(newstrokatt5.ToUpper().Replace(" ", "-"));
//-------------------------------------------
// Console.WriteLine("Задача 5 - 2 способ ");
// string strokatt5 = "HTML{0}JavaScript{1}PHP";
// strokatt5 = string.Format(strokatt5, "-", "-");
// Console.WriteLine(strokatt5.ToUpper());
// // ______________________________________________________________________
// 6. Ввести строку. +Проверить является ли это число или строка. +Если число, то
// ошибка ввода. Если это строка то первый символ поставить в верхний регистр.
// Убрать лишние пробелы
Console.WriteLine("Задача 6");
string? strokatt6 = Console.ReadLine();
if (!int.TryParse(strokatt6, out _) && !string.IsNullOrEmpty(strokatt6))
{
    strokatt6 = strokatt6.Trim();
    string bykva1strokatt6 = Convert.ToString(char.ToUpperInvariant(strokatt6[0]));
    string newstrokatt6 = strokatt6.Remove(0, 1);
    strokatt6 = string.Concat(bykva1strokatt6, newstrokatt6);
    Console.WriteLine(strokatt6);
}
else
{
    Console.WriteLine("Ошибка ввода");
}
//2 способ можно докртить
// // string newstrokatt6 = strokatt6.Replace(strokatt6[0], bykva1strokatt6);
// int symbolstroki = strokatt6.Length;
// Console.WriteLine(symbolstroki);
// strokatt6 = string.Concat(newstrokatt6[0], strokatt6);
// ______________________________________________________________________
// 7. На вход программе подаётся строка. Замените все @ на '!' с помощью
// глобального поиска и замены (2 способа)
Console.WriteLine("Задача 7");
string? strokatt7 = Console.ReadLine();
Console.WriteLine(strokatt7.Replace('@', '!'));

// ______________________________________________________________________
// 8.
// Дана строка 'aaa bbb ccc'. Вырежите из нее слово 'bbb'
Console.WriteLine("Задача 8");
string strokatt8 = "aaa bbb ccc";
Console.WriteLine(strokatt8.Remove(4, 4));

// ______________________________________________________________________
// 9. На вход программе подается переменная date, в котрой лежит дата в формате
// 'xxxx-xx-xx'. Преобразуйте эту дату в формат 'xx/xx/xxxx’. reverse)
Console.WriteLine("Задача 9");
string strokatt9 = "2022-10-31";
string[] massiv = strokatt9.Split('-');
Console.WriteLine($"{massiv[2]}/{massiv[1]}/{massiv[0]}");
// ______________________________________________________________________
// 10.
// Дана строка из 3 слов разделенных пробелом
// •
// Найдите количество символов в этой строке.
// •
// Вырежите из нее 2 и 3 слова.
// •
// Найдите индекс 2 подстроки
Console.WriteLine("Задача 10");
string strokatt10 = "tell me please";
string strokatt10remove = strokatt10.Remove(0, 5);
Console.WriteLine(strokatt10remove);
string[] massiv10 = strokatt10.Split(" ");
Console.WriteLine($"{massiv10[1]},{massiv10[2]}");
Console.WriteLine(strokatt10.IndexOf("m"));
Console.WriteLine(strokatt10.LastIndexOf("m"));
Console.WriteLine(strokatt10.Length);
// ______________________________________________________________________
// 11.
// Пользователь вводит дату в формате ‘х-х-х'. Замените все дефисы на '!'
Console.WriteLine("Задача 11");
string? data11 = Console.ReadLine();
Console.WriteLine(data11.Replace('-', '!'));
// ______________________________________________________________________
// 12.
// Пользователь вводит дату в формате 'xxxx-xx-xx'. Преобразуйте эту дату в формат
// 'xx.xx.xxxx'
Console.WriteLine("Задача 12");
string? data12 = Console.ReadLine();
string[] massiv12 = data12.Split('-');
Console.WriteLine($"{massiv12[2]}.{massiv12[1]}.{massiv12[0]}");
// ______________________________________________________________________
// 13.
// Дан массив ['я', 'учу', 'javascript', '!']. С помощью метода join преобразуйте массив в
// строку 'я+учу+javascript+!'.
string[] massiv13 = { "я", "учу", "javascript", "!" };
Console.WriteLine(string.Join("+", massiv13));
// ______________________________________________________________________
// 14.
// Дан массив. Вывести каждый одельный элемент в консоль ( for)
Console.WriteLine("Задача 14");
string[] massiv14 = { "математика", "биология", "география", "физика" };
for (int i = 0; i < massiv14.Length; i++)
{
    System.Console.WriteLine(massiv14[i]);
}

// 15.
// На вход программе подается строка текста, состоящая из слов, разделенных
// ровно одним пробелом. Напишите программу, которая подсчитывает количество
// слов в ней
Console.WriteLine("Задача 15");
string? strokatt15 = Console.ReadLine();
Console.WriteLine(strokatt15.Split(' ').Length);

// 16.
// Пользователь вводит строку. Необходимо посчитать количество гласных ( for)
Console.WriteLine("Задача 16");
string? strokatt16 = Console.ReadLine();
int kolglas = 0;
for (int i = 0; i < strokatt16.Length; i++)
{
    if (strokatt16[i] == 'a' || strokatt16[i] == 'e' || strokatt16[i] == 'i' || strokatt16[i] == 'o' || strokatt16[i] == 'u' || strokatt16[i] == 'y')
    { kolglas++; }
}
System.Console.WriteLine(kolglas);

// 17.
// Пользователь вводит строку. Необходимо посчитать количество согласных ( for)
Console.WriteLine("Задача 17");
string? strokatt17 = Console.ReadLine();
int kolsoglas = 0;
if (!string.IsNullOrEmpty(strokatt17))
{
    for (int i = 0; i < strokatt17.Length; i++)
    {
        if (strokatt17[i] == 'b' ||
            strokatt17[i] == 'c' ||
            strokatt17[i] == 'd' || strokatt17[i] == 'q' ||
            strokatt17[i] == 'w' || strokatt17[i] == 'r' ||
            strokatt17[i] == 't' || strokatt17[i] == 'p' ||
            strokatt17[i] == 's' || strokatt17[i] == 'j' ||
            strokatt17[i] == 'f' || strokatt17[i] == 'g' ||
            strokatt17[i] == 'h' || strokatt17[i] == 'l' ||
            strokatt17[i] == 'z' || strokatt17[i] == 'x' ||
            strokatt17[i] == 'v' || strokatt17[i] == 'n' ||
            strokatt17[i] == 'm')
        { kolsoglas++; }
    }
    System.Console.WriteLine(kolsoglas);
}
else
{
    System.Console.WriteLine("Вы ввели пустоту или Null");
}

// 18.
// Пользователь вводит строку. Необходимо вывести все гласные отдельной
// строкой ( for)
// fullstack => ua
Console.WriteLine("Задача 18");
string? strokatt18 = Console.ReadLine();
if (!string.IsNullOrEmpty(strokatt18))
{
    for (int i = 0; i < strokatt18.Length; i++)
    {
        if (strokatt18[i] == 'a' || strokatt18[i] == 'e' || strokatt18[i] == 'i' || strokatt18[i] == 'o' || strokatt18[i] == 'u' || strokatt18[i] == 'y')
        { System.Console.WriteLine(strokatt18[i]); }
    }

}
else { System.Console.WriteLine("Вы ввели пустоту или Null"); }

// 19.
// На вход программе подается строка. Преобразуйте первую букву каждого слова
// строки в верхний регистр (for)
Console.WriteLine("Задача 19");
string? strokatt19 = Console.ReadLine();
if (!string.IsNullOrEmpty(strokatt19))
{
    string[] strokatt19massiv = strokatt19.Split(' ');

    for (int i = 0; i < strokatt19massiv.Length; i++)
    {
        string elementmassiva = strokatt19massiv[i].ToString();
        Console.WriteLine(char.ToUpper(elementmassiva[0]) + elementmassiva.Remove(0, 1));
    }
}
else { System.Console.WriteLine("Вы ввели пустоту или Null"); }

//20 На вход программе подается строка, где каждое слово заканчивается “_”.
// Программа должна убрать “_” и первую букву каждого слова (помимо первого),
// преобразовать в верхний регистр (for)

Console.WriteLine("Задача 20");
string? str20 = Console.ReadLine();
if (!string.IsNullOrEmpty(str20))
{
    string[] array20 = str20.Split('_');
    string? s20n = "";
    s20n += array20[0];
    System.Console.WriteLine(s20n);
    for (int index20 = 1; index20 < array20.Length; index20++)
    {
        string? newstr = Convert.ToString(array20[index20]);
        s20n += String.Concat(char.ToUpper(newstr[0]), newstr.Remove(0, 1));
    }
    System.Console.WriteLine(s20n);
}
else
{
    System.Console.WriteLine("Пустая строка или налл");
}

// 21. На вход программе подается строка, состоящая из имени и фамилии человека,
// разделенных одним пробелом. Напишите программу, которая проверяет, что имя
// и фамилия начинаются с заглавной буквы.
// Chris Alan => true
// chris alan => false

Console.WriteLine("Задача 21");
string? str21 = Console.ReadLine();
if (!string.IsNullOrEmpty(str21))
{
    string[] array21 = str21.Split(' ');
    int index21 = 0;
    if (char.IsUpper(array21[index21][0]) && char.IsUpper(array21[index21 + 1][0]))
    { System.Console.WriteLine(true); }
    else { System.Console.WriteLine(false); }

}

// 22 На вход программе подается строка. Напишите программу, которая меняет 
// регистр символов, другими словами замените все строчные символы заглавными 
// и наоборот.
// Swap Case => sWAP cASE
// text = text?.Trim();
if (!string.IsNullOrEmpty(text)) //Is or Has => string.IsXXX or string.HasXXX результат true or false
{
    string result = "";
    for (int i = 0; i < text.Length; i++)
    {
        if (char.IsUpper(text[i]))
        {
            result += char.ToLower(text[i]).ToString(); // Convert.ToString( char.ToLower(text[i]))
        }
        else if (char.IsLower(text[i]))
        {
            result += char.ToUpper(text[i]).ToString();
        }
        else
        {
            result += text[i].ToString();
        }
    }

    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Empty string");
}

//23. На вход программе подается строка текста. Напишите программу, которая
// определяет является ли строка хорошей. Текст хороший, если содержит
// подстроку «хорош» во всевозможных регистрах.
// я очень хороший текст = => true


Console.WriteLine("Задача 23");
string? str22 = Console.ReadLine();
string array22like = "ХОРОШ";
if (!string.IsNullOrEmpty(str22))
{
    str22 = str22.ToUpper();
    string[] array22 = str22.Split(' ');
    for (int index22 = 0; index22 < str22.Length; index22++)
    {
        if (array22[index22].Contains(array22like))
        {
            System.Console.WriteLine(true);
            break;
        }
        else
        {
            System.Console.WriteLine(false);
            break;
        }
    }
}
else
{
    System.Console.WriteLine("Пустота или налл");
}

// 24. На вход программе подается строка. Напишите программу, которая подсчитывает
// количество буквенных символов в нижнем регистре.
// abcABCD12345 => 3

Console.WriteLine("Задача 24");
string? str23 = Console.ReadLine();
int schet = 0;
if (!string.IsNullOrEmpty(str23))
{
    for (int index24 = 0; index24 < str23.Length; index24++)
    {
        if (char.IsLower(str23[index24]))
            schet += 1;
    }
    System.Console.WriteLine(schet);
}
else { System.Console.WriteLine("Пустота или налл"); }