// 1.
// Ввести строку. Если эта равна “hschool”, вывести true. В противном случае false.
// Добавить проверки для строк . Удалить лишние пробелы

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

string textUser = "Full сStaCK DevELoper";
textUser = textUser.ToLower();
string[] result1 = textUser.Split(' ');
System.Console.WriteLine(result1[0]);
System.Console.WriteLine(result1[1]);
System.Console.WriteLine(result1[2]);
// ______________________________________________________________________
// 4. Ввести строку. Проверить на isNaN . Если число, то ошибка ввода. Если это строка
// то узнать какая у нее длина. Привести к одному регистру, убрать лишние пробелы

string? strokatt4 = Console.ReadLine();
if (!int.TryParse(strokatt4, out _) && !string.IsNullOrEmpty(strokatt4))
{
    Console.WriteLine(strokatt4.Trim().ToUpper());
}
else
{
    Console.WriteLine("Вы ввели число или пустую строку");
}









