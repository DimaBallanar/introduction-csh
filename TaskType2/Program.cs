// 1.Найти максимальное число из 2 введенных (2 способа)
//-------------------------------------------------
int chis = Convert.ToInt32(Console.ReadLine());
int chis1 = Convert.ToInt32(Console.ReadLine());
if (chis>chis1)
{
    Console.WriteLine("1 число максимальное из 2 введённых");
}
else if (chis==chis1)
{
    Console.WriteLine("1 число равно 2");
}
else 
{
    Console.WriteLine("2 число максимальное из 2 введённых");
}


//-------------------------------------------------
int chis2 = Convert.ToInt32(Console.ReadLine());
int chis3 = Convert.ToInt32(Console.ReadLine());
int chis4 = Math.Max(chis2, chis3);
Console.WriteLine($"{chis4}");

//_______________________________________________________________
// 2. Выявить является ли введенное число четным
//-------------------------------------------------
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
//----------------------------
int chet1 = Convert.ToInt32(Console.ReadLine());
string result = chet switch 
{
    >= 0 when chet1 % 2 == 0 => "Число чётное",
    > 0 when chet1 % 2 != 0 => "Число нечётное",
    < 0  when chet1 % 2 == 0 => "Число чётное",
    < 0 when chet1 % 2 != 0 => "Число нечётное",
};
System.Console.WriteLine(result);
//_______________________________________________________________

// 3.
// Пользователь вводит число от 1 до 7, соответствующее дню недели. Необходимо
// вывести день для введенного числа.
// 1 --> Понедельник

int dennedelya = Convert.ToInt32(Console.ReadLine());
if (dennedelya == 1)
{
Console.WriteLine ($"{dennedelya} --> Понедельник");
}
else if (dennedelya == 2)
{
Console.WriteLine ($"{dennedelya} --> Вторник");
}
else if (dennedelya == 3)
{
Console.WriteLine ($"{dennedelya} --> Среда");
}
else if (dennedelya == 4)
{
Console.WriteLine ($"{dennedelya} --> Четверг");
}
else if (dennedelya == 5)
{
Console.WriteLine ($"{dennedelya} --> Пятница");
}
else if (dennedelya == 6)
{
Console.WriteLine ($"{dennedelya} --> Суббота");
}
else if (dennedelya == 7)
{
Console.WriteLine ($"{dennedelya} --> Воскресенье");
}
//---------------------------- 
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