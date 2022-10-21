// 1.
// Вы вводите значение с клавиатуры. Если значение равно 0, то вывести ‘Ноль’,
// если < 0, то вывести ‘Отрицательное’, если > 0, то вывести ‘Положительное’
// // --------------------------------
// int flower = Convert.ToInt32(Console.ReadLine());

// if (flower < 0)
// {
//     Console.WriteLine("Отрицательное");
// }
// else if (flower == 0)
// {
//     Console.WriteLine($"{flower}");
// }
// else
// {
//     Console.WriteLine("Положительное");
// }
// // --------------------------------


int flower = Convert.ToInt32(Console.ReadLine());
string vyvod;
vyvod = (flower < 0 ) ? "Отрицательное" : (flower > 0 ) ? "Положительное" : "0";
Console.WriteLine(vyvod);
