internal class Program
{
    static void Main(string[] args)
    {
        Task1();
        // Task2();
        // Task3();
    }
    #region Task1

    // На входе дано три массива заполненных случайными числами. Написать метод
    // по подсчёту общего количества чётных чисел в массивах. (ref)
    static void Task1()
    {
        double[] array = { 2, 4, 6, 5, 8, 9 };
        double[] array1 = { 2, 4, 6, 5, 8, 9 };
        double[] array2 = { 2, 4, 6, 5, 9 };
        double podschet = 0;
        System.Console.WriteLine(ChetNumber(array, ref podschet));
        System.Console.WriteLine(ChetNumber(array1, ref podschet));
        System.Console.WriteLine(ChetNumber(array2, ref podschet));
    }
    static double ChetNumber(double[] array, ref double podschet)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                podschet++;
            }
        }
        return podschet;
    }

    #endregion
}