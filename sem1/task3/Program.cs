/*See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Напишите программу, которая будет выдавать 
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

Console.WriteLine("Введите число");
int dat = Convert.ToInt32(Console.ReadLine());


if (dat == 1)
{Console.WriteLine("Понедельник");}
else if (dat == 2)
{Console.WriteLine("Вторник");}
else if (dat == 3)
{Console.WriteLine("Среда");}
else if (dat == 4)
{Console.WriteLine("Четверг");}
else if (dat == 5)
{Console.WriteLine("Пятница");}
else if (dat == 6)
{Console.WriteLine("Суббота");}
else if (dat == 7)
{Console.WriteLine("Воскресенье");}
else 
{Console.WriteLine("Такого дня недели нет");}
