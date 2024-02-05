Console.WriteLine("ВВедите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a < 100)
Console.WriteLine("нету третьей цифры");
else
Console.WriteLine("Да, " + a / 100 % 10);