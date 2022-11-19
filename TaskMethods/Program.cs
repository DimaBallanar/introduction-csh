internal class Program
{
    static void Main(string[] args)
    {
        // Task1();
        Task2();
    }

    #region Задача1
    // Пользователь вводит имя и фамилию. Необходимо создать метод возвращающую строку вида «Привет, {имя} {фамилия}»
    static void Task1()
    {
        System.Console.WriteLine("введите имя");
        string? name = Console.ReadLine();
        System.Console.WriteLine("введите фамилию");
        string? lastname = Console.ReadLine();
        System.Console.WriteLine(HelloMethod(name, lastname));
    }
    static string HelloMethod(string name, string lastname)
    {
        return $"Привет, {name} {lastname}";
    }
    #endregion
}