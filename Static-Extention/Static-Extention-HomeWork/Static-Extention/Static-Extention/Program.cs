





#region Factorial-Power-Extention

using Static_Extention.Helper;
using System.Xml.Linq;

//1) int ucun faktoriali hesablayan extention yazin.

int num = 5;


Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(num.GetFactorial());






//2) int ucun methoda gelen reqeme gore ustu hesablayan extention yazin.
//(Meselen :  int a = 5; b = 3, Cavab cixmalidir : 125)


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Ededi daxil edin");
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Red;
int number = int.Parse(Console.ReadLine());
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Quvveti daxil edin");
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Red;
int power = int.Parse((string)Console.ReadLine());
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($" Result:");
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(number.GetNumPower(power));
Console.ResetColor();
#endregion
