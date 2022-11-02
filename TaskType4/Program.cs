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