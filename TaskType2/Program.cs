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
