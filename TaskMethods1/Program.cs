internal class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
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



    #region Task2
    //     Написать метод, который проверяет является ли введнная строка почтовым
    // адрессом и возвращающий домен почты. почты.(Out)
    static void Task2()
    {
        string email = "rtty@gmail.com";
        TryFalseEmail(email, out string result, out string domen);
        System.Console.WriteLine($"{domen},{result}");
    }
    static string TryFalseEmail(string email, out string result, out string domen)
    {
        domen = "";
        result = "false";
        if (email.Contains("@gmail.com"))
        {
            domen = "@gmail.com";
            result = "true";
        }
        return domen;
        return result;

    }
    #endregion
}