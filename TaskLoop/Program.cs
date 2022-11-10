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