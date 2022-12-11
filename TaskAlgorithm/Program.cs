//TaskAlogoritm Вне задач
int BinarySearchIndex(int[] userArray, int numSearch, int indexStart, int indexEnd)
{

    if (indexStart > indexEnd)
    {
        return -1;
    }
    int middleIndex = (indexEnd + indexStart) / 2;
    if (numSearch == userArray[middleIndex])
    {
        return middleIndex;
    }
    if (numSearch > userArray[middleIndex])
    {
        return BinarySearchIndex(userArray, numSearch, middlAeIndex + 1, indexEnd);
    }
    else
    {
        return BinarySearchIndex(userArray, numSearch, indexStart, middleIndex - 1);
    }
}

// [0,4] 5 ищем
int[] userMassiv = { 1, 4, 5, 7, 8, 9, 22, 23, 25, 33, 39, 44, 46, 55, 88, 99 };
// int[] userMassiv = { 0, 4 };
int number = Convert.ToInt32(Console.ReadLine());
int index = BinarySearchIndex(userMassiv, number, 0, userMassiv.Length - 1);
System.Console.WriteLine(index);