// // // 1. Выведите столбец чисел от 1 до 50. for, while
// // // 
{
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
}

//2. [1 , 2, 3, 4, 5]. Выведите каждый элемент массива 3 любыми циклами
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
