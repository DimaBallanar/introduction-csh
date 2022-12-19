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
        Task12();
        Task13();
        Task14();
        Task15();
        Task152();

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
        System.Console.WriteLine("Task1");
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
        System.Console.WriteLine("Task2");
        string? str = Console.ReadLine();
        System.Console.WriteLine(ConverterString(str));
    }
    static string ConverterString(string line)
    {
        
        string[] array1 = line.Split(' ');     // стоит убрать лишние пробелы,иначе "Index was outside the bounds of the array." "введи слово привет,поставь пробел и потом ентер"
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
        System.Console.WriteLine("Task3");
        string[] text = { "by", "belarus", "de", "ru", "germany" };
        Console.WriteLine(string.Join(",", MethodReplace(text))); //by,de,ru,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
    }                                                             // выводит такое сообщение) 
    static string[] MethodReplace(string[] text)
    {
      //  string[] result = new string[100];     // я бы указал длинну массива не 100,а [text.Length]  , но все равно проблема с лишними запятыми остается
      //  int i = 0;
       // foreach (string item in text)
       // {
       //     if (item.Length < 3)
       / /    {
          //      result[i] += item;
          //      i++;
          //  }
      //  }
        return result;
        
        // а вообще я бы сделал так
        
         string timeText="";
                int i = 0;
        foreach (string item in text)
        {
            if (item.Length < 3)
            {
                timeText+=item+",";
                i++;
            }
        }
        timeText=timeText.Remove(timeText.Length-1,1);
        string[] result = timeText.Split(",");
        return result;
       }
        
    }
    #endregion
    #region Задача 4
    // 4. На входе массив. Реализовать метод проверки на то что 
    // в массиве только числа. Метод возвращает true, если в 
    // массиве  только числа и false в противном случае
    static void Task4()
    {
        System.Console.WriteLine("Task4");
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
        System.Console.WriteLine("Task5");
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
        System.Console.WriteLine("Task52");
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
        System.Console.WriteLine("Task6");
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
        System.Console.WriteLine("Task7");
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
        System.Console.WriteLine("Task8");
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

    #region Task12
    //     На входе строка. Необходимо создать метод, возвращающий true, если это слово
    // палиндром и false в противном случае
    // Task12
    //     На входе строка. Необходимо создать метод, возвращающий true, если это слово
    // палиндром и false в противном случае
    static void Task12()
    {
        System.Console.WriteLine("Task12");
        string str1 = "frerf";
        if (Ren(str1) == true)
        {
            System.Console.WriteLine(true);
        }
        else { System.Console.WriteLine(false); }
    }
    static bool Ren(string str)
    {
        char[] array = new char[str.Length];
        bool result = false;
        for (int i = 0; i < str.Length; i++)
        {
            array[i] = Convert.ToChar(str[i]);
        }
        string[] array1 = new string[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            array1[i] = Convert.ToString(str[i]);
        }
        string[] array2 = array1.Reverse().ToArray();
        for (int i = 0; i < str.Length; i++)
        {

            if (array1[i] == array2[i])
            {
                result = true;
            }
        }
        return result;
    }
    #endregion

    #region Task13
    //  На входе строка. Необходимо создать метод, возвращающий true, если это слово
    // анаграмма и false в противном случае

    static void Task13()
    {
        System.Console.WriteLine("Task13");
        string str = "getg";
        string str1 = "tgeg";
        System.Console.WriteLine(StrAnagrama(str, str1));
    }
    static bool StrAnagrama(string stroka, string stroka1)
    {
        bool result = true;
        string[] array = new string[stroka.Length];
        string[] array1 = new string[stroka1.Length];
        if (stroka.Length == stroka1.Length)
        {
            for (int i = 0; i < stroka1.Length; i++)
            {
                array[i] = Convert.ToString(stroka[i]);
                array1[i] = Convert.ToString(stroka1[i]);
            }
        }
        Array.Sort(array);
        Array.Sort(array1);

        for (int i = 0; i < stroka.Length; i++)
        {
            if (array[i] != array1[i])
            {
                result = false;
            }
        }
        return result;
    }
    #endregion

    #region Task14
    //     Реализовать метод возвращающий разность между НОК и НОД для двух чисел
    static void Task14()
    {
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(DifferenceNokAndNod(number1, number2));
    }
    static int DifferenceNokAndNod(int number, int number1)
    {
        int nod = 0;
        int nok = 0;
        int raznost = 0;
        int gran = number * number1;
        for (int i = 1; i <= gran; i++)
        {
            if (number % i == 0 && number1 % i == 0)
            {
                nod = i;
            }
        }
        System.Console.WriteLine(nod);
        nok = number * number1 / nod;
        System.Console.WriteLine(nok);
        raznost = nok - nod;
        return raznost;
    }
    #endregion
    #region Task 15
    //     Реазуйте методы перевода чисел из десятичной системы счисления в 2-ую и 16-
    // ую
    static void Task15()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(MethodConvertto2(number));
        System.Console.WriteLine(MethodConvertto16(number));
    }
    static string MethodConvertto2(int number)
    {
        int ostatokotdel = 0;
        string numberin2 = "";
        string numberin2right = "0";
        while (number >= 1)
        {
            ostatokotdel = number % 2;
            numberin2 += ostatokotdel;
            number = number / 2;
        }
        for (int j = numberin2.Length - 1; j >= 0; j--)
        {
            numberin2right += numberin2[j];
        }
        return numberin2right;
    }
    static string MethodConvertto16(int number)
    {
        int ostatokotdel = 0;
        string numberin2 = "";
        string numberin2right = "";
        while (number >= 1)
        {
            ostatokotdel = number % 16;
            if (ostatokotdel == 10)
            {
                numberin2 += "A";
            }
            else if (ostatokotdel == 11)
            {
                numberin2 += "B";
            }
            else if (ostatokotdel == 12)
            {
                numberin2 += "C";
            }
            else if (ostatokotdel == 13)
            {
                numberin2 += "D";
            }
            else if (ostatokotdel == 14)
            {
                numberin2 += "E";
            }
            else if (ostatokotdel == 15)
            {
                numberin2 += "F";
            }
            else
            {
                numberin2 += ostatokotdel;
            }
            number = number / 16;
        }
        for (int j = numberin2.Length - 1; j >= 0; j--)
        {
            numberin2right += numberin2[j];
            System.Console.WriteLine(numberin2right);
        }
        return numberin2right;
    }
    #endregion
    #region Task 15
    //     Реазуйте методы перевода чисел из десятичной системы счисления в 2-ую и 16-ую
    static void Task152()
    {
        object[] array16 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F" };
        object[] array2 = { 0, 1 };
        int number = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(MetrhodConvertNumberic(number, array16));
        System.Console.WriteLine(MetrhodConvertNumberic(number, array2));


    }
    static string MetrhodConvertNumberic(int number, object[] array)
    {
        string numberin = "";

        while (number >= 1)
        {
            numberin += array[number % array.Length].ToString();
            number /= array.Length;
        }
        return new string(numberin.Reverse().ToArray());

        // number % array.Length

    }
    #endregion
}


