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