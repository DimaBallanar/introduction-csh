internal class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task52();
        Task6();
        Task7();
        Task8();
        Task9();
        Task10();
        Task11();

    }
    static bool MethodIsNumber(object[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] is not int)
            {
                return false;
            }
        }
        return true;
    }
    static bool MethodIsString(object[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] is not string)
            {
                return false;
            }
        }
        return true;
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

    #region Задача 2
    // 2.Напишите метод, который принимает строку в маленьком регистре и возаращает
    // строку, где каждое слово начинается с большого регистра
    // hschool company --> Hschool C ompany
    static void Task2()
    {
        string? str = Console.ReadLine();
        System.Console.WriteLine(ConverterString(str));
    }
    static string ConverterString(string line)
    {
        string[] array1 = line.Split(' ');
        for (int i = 0; i < array1.Length; i++)
        {
            string text = array1[i];
            // преобразования текста 
            text = char.ToUpper(text[0]) + text.Remove(0, 1);
            array1[i] = text;
        }
        return string.Join(' ', array1);

    }
    #endregion

    #region Задача 3 
    // 3. Напишите метод, который принимает статичный массив строк. Необходимо отфильтровать значения и оставить только те, где длина строк до 2 символов.
    //  [“by”, “belarus”, “de”, “ru”, “germany”] -> [“by”, “de”, “ru”]
    static void Task3()
    {
        string[] text = { "by", "belarus", "de", "ru", "germany" };
        Console.WriteLine(string.Join(",", MethodReplace(text)));
    }
    static string[] MethodReplace(string[] text)
    {
        string[] result = new string[100];
        int i = 0;
        foreach (string item in text)
        {
            if (item.Length < 3)
            {
                result[i] += item;
                i++;
            }
        }
        return result;
    }
    #endregion
    #region Задача 4
    // 4. На входе массив. Реализовать метод проверки на то что 
    // в массиве только числа. Метод возвращает true, если в 
    // массиве  только числа и false в противном случае
    static void Task4()
    {
        object[] objs = { 1, 333, 4, "eg", 975 };
        bool result = MethodSearch(objs);
        System.Console.WriteLine(result);
    }
    static bool MethodSearch(object[] array)
    {
        bool reslut = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] is int number)
            {
                reslut = true;
            }
            else
            {
                reslut = false;
                break;
            }
        }
        return reslut;
    }
    #endregion
    #region Task5 
    //      На входе n количество элементов массива (вводится с клавиатуры). Далее
    // производится заполнение массива с слуйчными числами. Реализуйте два метода
    // для поиска минимального и максимального значения.
    static void Task5()
    {
        int numberareaarray = Convert.ToInt32(Console.ReadLine());
        int min1 = MinMaxarrayelement(numberareaarray);
        System.Console.WriteLine(min1);
    }
    static int MinMaxarrayelement(int numberareaarray)
    {
        int[] array1 = new int[numberareaarray];
        int min = array1[0];

        for (int i = 0; i < numberareaarray; i++)
        {
            array1[i] = new Random().Next();
            System.Console.WriteLine(array1[i]);
        }
        min = array1.Min();
        return min;
    }
    #endregion
    #region Task52
    static void Task52()
    {
        int numberareaarray = Convert.ToInt32(Console.ReadLine());
        int min1 = MinMaxarrayelement1(numberareaarray);
        int max1 = Maxarrayelement(numberareaarray);
        System.Console.WriteLine(min1);
        System.Console.WriteLine(max1);
    }
    static int MinMaxarrayelement1(int numberareaarray)
    {
        int[] array1 = new int[numberareaarray];
        int min = array1[0];

        for (int i = 0; i < numberareaarray; i++)
        {
            array1[i] = new Random().Next(-100, 100);
            System.Console.WriteLine(array1[i]);
            if (min > array1[i])
            {
                min = array1[i];
            }
        }
        return min;
    }
    static int Maxarrayelement(int numberareaarray) //понимаю, что будет новый  рандомный ряд, тренировался на том, чтобы более значительные моменты в определение закидывать
    {
        int[] array1 = new int[numberareaarray];
        int max = array1[0];
        for (int i = 0; i < numberareaarray; i++)
        {
            array1[i] = new Random().Next(-100, 100);
            System.Console.WriteLine(array1[i]);
            if (max < array1[i])
            {
                max = array1[i];
            }
        }
        return max;
    }
    #endregion
    #region Task6
    // На входе n – количество элементов массива (вводится с клавиатуры). Далее 
    // производится заполнение массива с слуйчными числами. Реализуйте методы 
    // подсчета количества элементов массива меньше и больше среднего значения. 
    static void Task6()
    {
        int numberareaarray = Convert.ToInt32(Console.ReadLine());
        int sumelement = 0;
        int[] array = new int[numberareaarray];
        for (int i = 0; i < numberareaarray; i++)
        {
            array[i] = new Random().Next(-100, 100);
            sumelement += array[i];
        }
        int middle = sumelement / numberareaarray;
        System.Console.WriteLine(string.Join(',', array));
        System.Console.WriteLine(middle);
        System.Console.WriteLine(CountLessMiddleNumber(middle, array));
        System.Console.WriteLine(CountMoreMiddleNumber(middle, array));
    }
    static int CountLessMiddleNumber(int middle, int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < middle)
            {
                count++;
            }
        }
        return count;
    }
    static int CountMoreMiddleNumber(int middle, int[] array)
    {
        int count1 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > middle)
            {
                count1++;
            }
        }
        return count1;
    }
    #endregion
    #region Task7
    //     На входе массив. Реализуйте 2 метода. Первый для проверки, что в массиве 
    // только числа. Второй для получения суммы всех элементов массива. Если 
    // результат метода проверки – true, то вызывать новый метод, возвращающий 
    // сумму всех элементов массива
    static void Task7()
    {
        object[] array1 = { 1, 2, 3, 4, 5 };
        if (MethodIsNumber(array1) == true)
        {
            System.Console.WriteLine(SumellemArray(array1));
        }
    }
    static decimal SumellemArray(object[] array)
    {
        decimal sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += Convert.ToDecimal(array[i]);
        }
        return sum;
    }

    #endregion

    #region Task 8
    // На входе массив. Реализуйте 2 метода. Первый для проверки, что в массиве 
    // только строки. Второй для получения суммы всех строчных элементов массива. 
    // Если результат метода проверки – true, то вызывать новый метод, возвращающую 
    // конкатенацию всех строчных элементов массива
    static void Task8()
    {
        object[] array1 = { "dr", "tg", "lf", "ui" };
        if (MethodIsString(array1) == true)
        {
            System.Console.WriteLine(SumellemstringArray(array1));
        }
    }
    static string SumellemstringArray(object[] array)
    {
        string sum = "";
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i] is string str ? str : default;
        }
        return sum;
    }
    #endregion
    #region Task 9 
    //     +На входе 2 массива, размерность которых вводится с клавиатуры, а значения
    // заполняются случайными числами+. Реализуйте 2 метода. +Первый что массивы
    // имеют одинаковую размерность и все элементы отличаются+. Второй произвести
    // поэлементное умножение. Если результат метода проверки – true, то вызывать
    //     // новый метод, возвращающий вывод элементов через запятую 
    // +Ты размерность ввводишь с клавиатуры для первогоо массива (длинна массива) и для второго массива
    // 1 метод сравниваешь длинну, чтоьы одинаковые были и вск элементы по индексам i элемент 1 и 2 массива 
    // если длинны одинаковые и элемнты разные, то вызываешь метод 
    // который создаёт новый массив в который записывает в i позицию произведение i элементов 1 и 2 массива
    static void Task9()
    {
        System.Console.WriteLine("Task9");
        int boardarray = Convert.ToInt32(Console.ReadLine());
        int boardarray1 = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[boardarray];
        int[] array1 = new int[boardarray1];
        for (int i = 0; i < boardarray; i++)
        {
            array[i] = new Random().Next(-100, 100);
        }
        for (int i = 0; i < boardarray1; i++)
        {
            array1[i] = new Random().Next(-100, 100);
        }
        if (Comparison(array, array1) == true)
        {
            int[] array0 = MultiplicationIndexs(array, array1);
            string str = string.Join(',', array0);
            System.Console.WriteLine(str);
        }


        static bool Comparison(int[] massiv, int[] massiv1)
        {
            bool result = false;
            if (massiv.Length == massiv1.Length)
            {
                for (int i = 0; i < massiv.Length; i++)
                {
                    if (massiv[i] != massiv1[i])
                    {
                        result = true;
                    }
                    else if (massiv[i] == massiv1[i])
                    {
                        result = false;
                    }
                }
            }
            else { System.Console.WriteLine("Введите одинаковую длинну массива"); }
            return result;
        }
        static int[] MultiplicationIndexs(int[] massiv, int[] massiv1)
        {
            int[] array0 = new int[massiv.Length];
            for (int i = 0; i < massiv.Length; i++)
            {
                array0[i] = (Convert.ToInt32(massiv[i]) * Convert.ToInt32(massiv1[i]));
                System.Console.WriteLine(array0[i]);
            }
            return array0;
        }
    }
    #endregion
    #region Task10
    //     На входе массив. Реализуйте 2 метода. Первый для проверки, что в массиве
    // только числа. Второй для получения только четных элементов массива. Если
    // результат метода проверки – true, то вызывать новую метод, возвращающий
    // массив с четными элементами массива


    static void Task10()
    {
        System.Console.WriteLine("Task10");
        string[] array = { "2", "1", "432", "468", "896" };
        if (IsNumber1(array) == true)
        {
            System.Console.WriteLine(string.Join(',', IsEvenNumbered(array)));
        }
    }

    static bool IsNumber1(string[] massiv)
    {
        bool result = false;
        for (int i = 0; i < massiv.Length; i++)
        {
            result = Convert.ToInt32(massiv[i]) is int number ? true : false;
        }
        return result;

    }
    static string[] IsEvenNumbered(string[] massiv)
    {
        string[] array0 = new string[massiv.Length];
        for (int i = 0; i < massiv.Length; i++)
        {
            if (Convert.ToInt32(massiv[i]) % 2 == 0)
            {
                array0[i] = massiv[i];
            }
        }
        return array0;
    }
    #endregion
        #region Task11

    // На входе число.Необходимо создать метод, возвращающий факториал числа.
    // Пример фактериала 4! = 1 * 2 * 3 * 4
    static void Task11()
    {
        System.Console.WriteLine("Task11");
        int chislo = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(Factorial(chislo));
    }
    static int Factorial(int number)
    {
        int chislo1 = 1;
        for (int i = 1; i <= number; i++)
        {
            chislo1 *= i;
        }
        return chislo1;
    }
    #endregion
}

