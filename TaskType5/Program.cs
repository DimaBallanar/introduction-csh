// // // 1. Выведите столбец чисел от 1 до 50. for, while
// // // 
// // {
// //     Console.WriteLine("Цикл for");
// //     for (int ind = 1; ind <= 50; ind++)
// //     {
// //         Console.WriteLine(ind);
// //     }
// //     int number = 1;
// //     Console.WriteLine("Цикл while");
// //     while (number < 50)
// //     {
// //         Console.WriteLine(number++);
// //     }
// // }
// // //2. [1 , 2, 3, 4, 5]. Выведите каждый элемент массива 3 любыми циклами
// // int[] array1 = new int[5] { 1, 2, 3, 4, 7 };
// // int i = 0;
// // while (i <= array1.Length)
// // {
// //     Console.WriteLine(array1[i]);
// //     i++;
// // }
// // //---------------
// // int[] array2 = new int[5] { 1, 2, 3, 4, 7 };
// // for (int t = 0; t < array2.Length; t++)
// // {
// //     Console.WriteLine(array2[i]);
// // }
// // //---------------
// // int[] array3 = new int[5] { 1, 2, 3, 4, 7 };
// // foreach (int item in array3)
// // {
// //     Console.WriteLine(item);
// // }
// // //---------------
// // int[] array4 = new int[5] { 1, 2, 3, 4, 7 };

// // foreach (int item in array3)
// // {
// //     Console.WriteLine(item);
// // }
// // item += item;

// // 3.
// // Дан массив с элементами [2, 3, 4, 5]. С помощью 3 циклов найдите произведение
// // элементов этого массива.

// int[] array4 = new int[4] { 2, 3, 4, 5 };
// int i = 0;
// int result = 1;
// while (i < array4.Length)
// {
//     result *= array4[i];
//     i++;
// }
// Console.WriteLine(result);
// // -------------------
// result = 1;
// for (int j = 0; j < array4.Length; j++)
// {
//     result *= array4[j];

// }
// Console.WriteLine(result);
// // -------------------
// result = 1;
// foreach (int item in array4)
// {
// result *= item;
// }
// Console.WriteLine(result);
// // -------------------
// 4.
// Выведите столбец чисел от 11 до 33 циклом while
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