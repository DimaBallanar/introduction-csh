int consoleNumber = Convert.ToInt32(Console.ReadLine());
string message;

if (consoleNumber < 0)
{
    message = "-";
}
else if (consoleNumber == 0)
{
    message = "0";
}
else
{
    message = "+";
}


message = consoleNumber < 0 ? "-" : consoleNumber == 0 ? "0" : "+";

System.Console.WriteLine(message);



--------------------------
var value = 5;

string? message = null;

if (value == 4)
{
    message = "Test";
}

System.Console.WriteLine(message ?? "Default Text")
---------------------------
var value = 5;

string? message = null;

if (value == 4) {
   message = "Test";
}

System.Console.WriteLine(message?.ToLower());