// 1. Пользователь вводит границы интервала из которого программа загадывает число.
// Написать программу про поиску данного числа. Пользователь пишит число в консоль,
// программа отвечает
System.Console.WriteLine("Задача 1");
System.Console.WriteLine("Введите интервал числа, программа выберет число из этого интервала, вам нужно будет угадать его");
object? ifnumber1 = Console.ReadLine();
object? ifnumber2 = Console.ReadLine();
int number1 = Convert.ToInt32(ifnumber1);
int number2 = Convert.ToInt32(ifnumber2);
int slucnumber = new Random().Next(number1, number2);
int number3;
do
{
    System.Console.WriteLine("Введите число, которое загадала програма");
    number3 = Convert.ToInt32(Console.ReadLine());
    if (slucnumber == number3)
    {
        break;
    }
}
while (true);
{
    System.Console.WriteLine("Вы угадали");
}

// 2.Написать программу, которая подсчитывает количество в строке букв, пробелов, цифр и
// остальных символов.
// ввод
// на массив строки
System.Console.WriteLine("Задача 2");
System.Console.WriteLine("Введите строку");
string? str = Console.ReadLine();
int symbol = 0;
int letter = 0;
int whitespace = 0;
int isnumber = 0;
for (int index = 0; index < str.Length; index++)
{
    if (Char.IsSymbol(str[index]))
    {
        symbol += 1;
    }
    else if (char.IsLetter(str[index]))
    {
        letter += 1;
    }
    else if (char.IsWhiteSpace(str[index]))
    {
        whitespace += 1;
    }
    else if (char.IsNumber(str[index]))
    {
        isnumber += 1;
    }
}
System.Console.WriteLine($"{symbol}-символы,{letter}-буквы, {whitespace}-пробелы, {isnumber}-цифры");

// если остальные символы имеется ввиду не специальные, то тогда 2 вариант