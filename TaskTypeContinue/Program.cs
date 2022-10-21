// 1.
// Вы вводите значение с клавиатуры. Если значение равно 0, то вывести ‘Ноль’,
// если < 0, то вывести ‘Отрицательное’, если > 0, то вывести ‘Положительное’
// P.S. vyvod = (flower < 0 ) ? "Отрицательное" : (flower > 0 ) ? "Положительное" : "0"; можно ли 0 вывести с WriteLine???
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
// // // --------------------------------


// int rt = Convert.ToInt32(Console.ReadLine());
// string vyvod;
// vyvod = (rt < 0) ? "Отрицательное" : (rt > 0) ? "Положительное" : "0";
// Console.WriteLine(vyvod);

// ----------------------------
// 2. Вы вводите значение с клавиатуры. Если значение четное, то вывести true, в
// противном случае false
// P.S. 
// // --------------------------------
// int qwerty = Convert.ToInt32(Console.ReadLine());
// qwerty = qwerty % 2;
// if (qwerty == 0)
// {
//     Console.WriteLine(true);
// }
// else
// {
//     Console.WriteLine(false);
// }
// // --------------------------------
// int qwerty2 = Convert.ToInt32(Console.ReadLine());
// bool qwertyvyvod;
// qwerty2 = qwerty2 % 2;
// qwertyvyvod = qwerty2 == 0 ? true : false;
// Console.WriteLine(qwertyvyvod);