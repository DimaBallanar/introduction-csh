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
// _____________________________________________
// 3. Пользователь вводит с клавиатуры число. Найдите корень введенного числа
// (если же результат число с плавающей точкой, то округлить до 2 знаков после
// запятой
// int chislo = Convert.ToInt32(Console.ReadLine());
// var chislo1 = Math.Sqrt(chislo);
// if (chislo1 % 1 == 0)
// {
//     Console.WriteLine($"{chislo1}");
// }
// else
// {
//     Console.WriteLine($"{Math.Round(chislo1, 2)}");
// }
// // --------------------------------
// int chisloternarny = Convert.ToInt32(Console.ReadLine());
// double chislo1ternarny = Math.Sqrt(chisloternarny);
// double chislo1ternarny1 = chislo1ternarny % 1;  
// chislo1ternarny = chislo1ternarny1 == 0 ? chislo1ternarny : Math.Round(chislo1ternarny, 2);

// Console.WriteLine($"{chislo1ternarny}");

//4. Пользователь вводит с клавиатуры 2 числа: a и b. Проверьте, что a делится без
// остатка на b. Если это так выведите 'Делится' и результат деления, иначе
// выведите 'Делится с остатком' и остаток от деления

// double opi = Convert.ToDouble(Console.ReadLine());
// double opi1 = Convert.ToDouble(Console.ReadLine());
// double opi2 = opi % opi1;
// double opi3 = opi / opi1;
// if (opi2 == 0)
// {
// Console.WriteLine($"Делится, результат деления: {opi3}");
// }
// else
// {
//     Console.WriteLine($"Делится с остатком, остаток от деления: {opi2}");
// }
// // --------------------------------
// Тут не знал как
// double opiternarny = Convert.ToDouble(Console.ReadLine());
// double opi1ternarny = Convert.ToDouble(Console.ReadLine());
// double opi2ternarny = opiternarny % opi1ternarny;
// double opi3ternarny = opiternarny / opi1ternarny;
// double opi4ternarny;
// opi4ternarny = opi2ternarny == 0 ? opi3ternarny : opi2ternarny;

// Console.WriteLine($"{opi4ternarny}");

// string opi6ternarny = Convert.ToString($"Делится с остатком, остаток от деления: {opi2ternarny}");
// string opi5ternarny = Convert.ToString($"Делится, результат деления: {opi3ternarny}");

// 5. Пользователь вводит с клавиатуры число. Найдите корень введенного числа
// (если же результат число с плавающей точкой, то округлить то целых)
// double five = Convert.ToDouble(Console.ReadLine());
// five = Math.Sqrt(five);
// if (five % 1 == 0)
//  {
//     Console.WriteLine($"{five}");
// }
// else
// {
//     Console.WriteLine($"{Math.Round(five)}");
// }
// // --------------------------------
// double fiveternarny = Convert.ToDouble(Console.ReadLine());
// fiveternarny = Math.Sqrt(fiveternarny);
// double fiveternarny1 = fiveternarny % 1;
// fiveternarny = fiveternarny1 == 0 ? fiveternarny : Math.Round(fiveternarny);
// Console.WriteLine($"{fiveternarny}");
// _____________________________________________
