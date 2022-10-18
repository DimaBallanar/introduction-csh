// // byte valuebyte = 0xFF;
// System.Byte valuesystembyte = 127;
// // sbyte valuesbyte = 127;
// // System.SByte second = -117;
// // short valueshort = 23;
// // System.Int16 valuesystemshort = 33;
// // int valueint = 320;
// // System.Int32 valuesystemint = 6;
// // long valuelong = 5225;
// // System.Int64 valueSystemLong = 5252;

// // var valueVar = 5262L;
// // var value = valuesystembyte + valuesystembyte + valuesystembyte; 
// // string boxer = "127";
// int valueParse = int.Parse("");
// int valueConvert = System.Convert.ToInt32(null);
// System.Console.WriteLine(valueConvert);
// System.Console.WriteLine(valueParse);

// var boxer = Console.ReadLine();
// int valueConvert = System.Convert.ToInt32(boxer);
// Console.WriteLine($"Я ввел число: {valueConvert} {valueConvert.GetType()}");

// Найти остаток от деления value1 от value2 и данный остаток сделать ++
// Console.Write("Введите число 1: ");
// var boxer = Console.ReadLine();
// int value = Convert.ToInt32(boxer);
// Console.Write("Введите число 2: ");
// var boxer1 = Console.ReadLine();
// int value1 = Convert.ToInt32(boxer1);
// int boxer2 = value % value1;
// Console.WriteLine(boxer2);
// int boxer3 = ++boxer2;
// Console.WriteLine($"Остаток от деления с префексным инкрементом: {boxer3} ");
// Console.WriteLine($"Остаток от деления с постфиксным инкрементом: {boxer2++} ");
// Console.WriteLine(boxer2);

// посчитать курс валют и заплатить налог и вывести сколько денег останется после налога
//--------------------
// Console.Write("курс валют $: ");
// var consoleText = Console.ReadLine();
// decimal rate = Convert.ToDecimal(consoleText);
// Console.Write("какой Tax: ");
// consoleText = Console.ReadLine();
// decimal tax = Convert.ToDecimal(consoleText);
// Console.Write("количество валюты: ");
// //consoleText = Console.ReadLine();
// decimal countmoney = Convert.ToDecimal(Console.ReadLine());
// // (количество валют * курс валют) * (1 - налог /100)
// decimal result; 
// result = (countmoney*rate) * (1 - tax /100);
// Console.WriteLine(result);

//1.Даны переменные a = 10 и b = 3. Найдите остаток от деления a на b.
int a = 10;
int b = 3;
int c = a % b;
Console.WriteLine(c);
