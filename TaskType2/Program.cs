// 1.Найти максимальное число из 2 введенных (2 способа)
//-------------------------------------------------
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
    < 0 when chet1 % 2 == 0 => "Число чётное",
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
//_______________________________________________________________
//4. Есть строка в 3 символа. Написать проверку если число, вывести true, в
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
//------------------------
var str2 = Console.ReadLine();
int str3;
bool proverka1 = int.TryParse(str2, out str3);
var result1 = proverka1 switch
{
    true => $"{str2} Это число",
    false => "false Char.IsDigit (str2, position)- Это строка"
};
System.Console.WriteLine(result1);
//------------------------
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
//_______________________________________________________________

// 5. Пользователь вводит число с клавиатуры. Нужно вывести на экран сколько в этом
// числе цифр, а также положительное оно или отрицательное. Например, 
// "Число " + num + " однозначное положительное". (Length)

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
//------------------------------------------------------------------------
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
//_______________________________________________________________

// 6. Найти квадратный корень числа. Если же число без плавающей точки, то просто
// вывести его. В противном случае необходимо округлить число до целых.
// Добавить проверку на ввод только чисел
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
//------------------------------------------------------------------------
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
//______________________________________________________________________________________________________________________________
