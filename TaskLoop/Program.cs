//1. 
{
    int[] numbers = { 1, 8, 654, 8, 465, 84, 654, 84 };
    int number = Convert.ToInt32(Console.ReadLine());
    int resultIndex = 0;
    int i = 0;
    for (i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == number)
        {
            resultIndex = i;
            break;
        }
        else
        {
            resultIndex = -1;
        }
    }
    Console.WriteLine(resultIndex);
}
{
    int[] numbers = { 1, 8, 654, 8, 465, 84, 654, 84 };
    int number = Convert.ToInt32(Console.ReadLine());
    int resultIndex = 0;
    int i = 0;
    for (i = numbers.Length - 1; -1 < i; i--)
    {
        if (numbers[i] == number)
        {
            resultIndex = i;
            break;
        }
        else
        {
            resultIndex = -1;
        }
    }
    Console.WriteLine(resultIndex);
}

//2. Задача массив строк нужно + все строки
string[] array = { "gdldgl", "sdfklsg", "fdsjks", "cvmklc" };
string sum = "";
for (int i = 0; i < array.Length; i++)
{
    sum += array[i];
}
System.Console.WriteLine(sum);

//3. 
{
    string[] array = { "github.com", "HannaPleshko" };
    string result1 = "";
    int i = 0;
    while (i < array.Length)
    {
        result1 += array[i] + "/";
        i++;
    }
    result1 = result1.Remove(result1.Length - 1);
    System.Console.WriteLine($"https://{result1}");
}
//4.
 int[] massivNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 123, 1242, 2352, 234, 242, 52, 66, 56, 46, 7, 75, 85, 3, 5 }; 
    System.Console.WriteLine("введите число"); 
    int userNumber = Convert.ToInt32(Console.ReadLine()); 
    int result = -1; 
    for (int i = 0; i < massivNumbers.Length; i++) 
    { 
        if (massivNumbers[i] == userNumber) 
        { 
            result = i; 
 
            break; 
        } 
    } 
    System.Console.WriteLine(result);