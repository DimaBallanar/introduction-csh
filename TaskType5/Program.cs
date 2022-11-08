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
    string array10string0 = Convert.ToString(array12[index12]);
    if (array10string0.StartsWith('1') || array10string0.StartsWith('2') || array10string0.StartsWith('5'))
        System.Console.WriteLine(array10string0);
}