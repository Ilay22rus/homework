Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number < 999999)
{
Console.WriteLine(number % 1000 / 100);
}
if (number < 999)
{
Console.WriteLine(number % 10);
}
if (number < 99)
{
Console.WriteLine("Третьей цыфры нет");
}