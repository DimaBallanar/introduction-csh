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