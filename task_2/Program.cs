Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if(number == 1)
{
Console.WriteLine("понедельник");
}
if(number == 2)
{
Console.WriteLine("Вторник");
}
if(number == 3)
{
Console.WriteLine("среда");
}
if(number == 4)
{
Console.WriteLine("Четверг");
}
if(number == 5)
{
Console.WriteLine("пятница");
}
if(number == 6)
{
Console.Write("Суббота");
}
if(number == 7)
{
Console.Write("Воскресенье");
}
if(number == 6 & number == 7)
{
Console.WriteLine("выходной");
}