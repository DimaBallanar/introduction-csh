// // // 1. Выведите столбец чисел от 1 до 50. for, while
// // // 
System.Console.WriteLine("Задача 1");
Console.WriteLine("Цикл for");
for (int ind = 1; ind <= 50; ind++)
{
    Console.WriteLine(ind);
}
int number = 1;
Console.WriteLine("Цикл while");
while (number < 50)
{
    Console.WriteLine(number++);
}

//2. [1 , 2, 3, 4, 5]. Выведите каждый элемент массива 3 любыми циклами
System.Console.WriteLine("Задача 2");
int[] array1 = new int[5] { 1, 2, 3, 4, 7 };
int l = 0;
while (l <= array1.Length)
{
    Console.WriteLine(array1[l]);
    l++;
}
//---------------
int[] array2 = new int[5] { 1, 2, 3, 4, 7 };
for (int t = 0; t < array2.Length; t++)
{
    Console.WriteLine(array2[t]);
}
//---------------
int[] array3 = new int[5] { 1, 2, 3, 4, 7 };
foreach (int item in array3)
{
    Console.WriteLine(item);
}
//---------------
int[] array45 = new int[5] { 1, 2, 3, 4, 7 };

foreach (int item in array45)
{
    Console.WriteLine(item);
}

// // 3.
// // Дан массив с элементами [2, 3, 4, 5]. С помощью 3 циклов найдите произведение
// // элементов этого массива.
System.Console.WriteLine("Задача 3");
int[] array4 = new int[4] { 2, 3, 4, 5 };
int i = 0;
int result = 1;
while (i < array4.Length)
{
    result *= array4[i];
    i++;
}
Console.WriteLine(result);
// -------------------
result = 1;
for (int j = 0; j < array4.Length; j++)
{
    result *= array4[j];

}
Console.WriteLine(result);
// -------------------
result = 1;
foreach (int item in array4)
{
    result *= item;
}
Console.WriteLine(result);
// // -------------------
// 4.
// Выведите столбец чисел от 11 до 33 циклом while
System.Console.WriteLine("Задача 4");
for (int k = 11; k <= 33; k++)
{
    System.Console.WriteLine(k);
}
// // -------------------
int number4 = 11;
while (number4 <= 33)
{
    System.Console.WriteLine(number4++);
}
// // -------------------
//_______________________________________
// // 5. Выведите столбец четных чисел в 
// промежутке от 0 до 100 ( for)
System.Console.WriteLine("Задача 5");
for (int z = 0; z <= 100; z += 2)
{
    Console.WriteLine(z);
}
//_______________________________________
// // 6. С помощью цикла while найдите сумму чисел от 1 до 100.
System.Console.WriteLine("Задача 6");
int sum = 1;
int resultsum = 0;
while (sum <= 100)
{
    resultsum += sum;
    sum++;
}
System.Console.WriteLine(resultsum);
//_______________________________________

// 7.
// Дан массив с элементами [1, 2, 3, 4, 5]. С помощью цикла for of найдите сумму
// элементов этого массива
System.Console.WriteLine("Задача 7");
int[] array7 = new[] { 1, 2, 3, 4, 5 };
int sumarray = 0;
for (int x = 0; x < array7.Length; x++)
{
    sumarray += array7[x];
}
Console.WriteLine(sumarray);

// //_______________________________________
// 8.Дан массив 2, 5, 9, 15, 0, 4. Выведите все числа кратные 3 циклом for each in
System.Console.WriteLine("Задача 8");

int[] array8 = new[] { 2, 5, 9, 15, 0, 4 };
foreach (int item1 in array8)
{
    if (item1 % 3 == 0)
    {
        Console.WriteLine(item1);
    }
}

// // //_______________________________________
// // 9. Дан массив с элементами [1, 2, 2, 3, 4, 4, 3, 4, 5]. Выведите только уникальные
// // значения массива --> 1, 5] ( for)

// 10. Дан массив 2, 5, 9, 15, 0, 4. Выведите все числа кратные 5 циклом while
System.Console.WriteLine("Задача 10");
int[] array10 = { 2, 5, 9, 15, 0, 4 };
int index10 = 0;
while (index10 < array10.Length)
{
    if (array10[index10] % 5 == 0)
    {
        System.Console.WriteLine(array10[index10]);
    }
    index10++;
}

//11.Дан массив с числами. Числа могут быть положительными и отрицательными.
// Найдите сумму всех положительных элементов массива циклом for each in
int[] array11 = new[] { 1, 4, -7, -44, 77, -88 };
int sum11 = 0;
foreach (int index11 in array11)
{
    if (index11 > 0)
        sum11 += index11;

}
System.Console.WriteLine(sum11);

//12.Дан массив числами, например: [10, 20, 30, 50, 235, 3000]. Выведите на экран только
// те числа из массива, которые начинаются на цифру 1, 2 или 5 --> 10, 20, 50, 235
int[] array12 = { 10, 20, 30, 50, 235, 3000 };

for (int index12 = 0; index12 < array12.Length; index12++)
{
    string array12string0 = Convert.ToString(array12[index12]);
    if (array12string0.StartsWith('1') || array12string0.StartsWith('2') || array12string0.StartsWith('5'))
        System.Console.WriteLine(array12string0);
}

// 13.
// Дан массив с элементами 1, 2, 3, 4, 5, 6, 7, 8, 9. С помощью цикла for создайте строку
// 1 2 3 4 5 6 7 8 9
int[] array13 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
string array13stringsum = "";
for (int index13 = 0; index13 < array13.Length; index13++)
{
    string array13string = Convert.ToString(array13[index13]);
    array13stringsum += array13string;
}
System.Console.WriteLine(array13stringsum);
// --------------------
// 2 способ
int[] array13new = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
string array13stringsum1 = "";
for (int index13new = 0; index13new < array13new.Length; index13new++)
{

    string array13string1 = string.Join(' ', array13new[index13new]);
    array13stringsum1 += array13string1;
}
System.Console.WriteLine(array13stringsum1);

// 14. Дано число 7, найдите все числа кратные 7 до 100
System.Console.WriteLine("Задача 14");
int number14 = 7;
for (int index14 = 0; index14 < 100; index14++)
{
    if (index14 % number14 == 0)
    {
        System.Console.WriteLine(index14);
    }
}

//15. Дано предложение и количество раз которое его надо повторить. Напишите
// программу, которая повторяет данное предложение нужное количество раз.
System.Console.WriteLine("Задача 15");
string? str15 = Console.ReadLine();
int? number15 = Convert.ToInt32(Console.ReadLine());
if (!string.IsNullOrEmpty(str15))
{
    for (int index15 = 0; index15 <= number15; index15++)
    {
        System.Console.WriteLine(str15);
    }
}
else
{ System.Console.WriteLine("Вы ввели пустоту"); }


// 16.
// Пользователь вводит число, явдяющееся количеством элементов будущего
// массива и выбирает тип данных массива. Напишите код заполнения массива
// выбранным типом данных

System.Console.WriteLine("Task 16");
int number16 = Convert.ToInt32(Console.ReadLine());
string? strsum16 = "";

for (int index16 = 0; index16 < number16; index16++)
{
    int? str16 = Convert.ToInt32(Console.ReadLine());
    strsum16 += str16 + ",";
}
string[] array16 = strsum16.Split(",");
System.Console.WriteLine(array16[0]);


//17. Пользователь вводит число, явдяющееся количеством элементов будущего
//массива. Напишите код заполнения массива Записать в массив только числа.
System.Console.WriteLine("Task 17");
int number17 = Convert.ToInt32(Console.ReadLine());
string? strsum17 = "";

for (int index17 = 0; index17 < number17; index17++)
{
    int? str17 = Convert.ToInt32(Console.ReadLine());
    strsum17 += str17 + ",";
}
string[] array17 = strsum17.Split(",");
System.Console.WriteLine(array17[0]);







// 18.
// Пользователь вводит многозначное число. Необходимо вставить двоеточие
// между двумя нечетными числами. Работать с числом как с массивом.
// Использовать for
// 55639217 --> 5:563:921:7.
// System.Console.WriteLine("Task 18");
// int number18 = Convert.ToInt32(Console.ReadLine());
// string str18 = Convert.ToString(number18);
// string[] array18 = str18.Split("");
// System.Console.WriteLine(array18[0]);

System.Console.WriteLine("Task 18");
int number18 = Convert.ToInt32(Console.ReadLine());
string? strchislo = Convert.ToString(number18);
string? strsum18 = "";
string? str1sum18 = "";
string? str18;
for (int index18 = 0; index18 < strchislo.Length - 1; index18++)
{
    System.Console.WriteLine("Повторите многозначное число по 1 цифре");
    str18 = Convert.ToString(Console.ReadLine());
    strsum18 += str18 + ",";
    System.Console.WriteLine(strsum18);
}
System.Console.WriteLine(str1sum18);
str1sum18 += strchislo[strchislo.Length - 1];
System.Console.WriteLine(str1sum18);
string[] array18 = strsum18.Split(",");
