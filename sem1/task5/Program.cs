/*See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Напишите программу, которая принимает на вход
трёхзначное целое число и на выходе показывает последнюю цифру этого числа.
456 => 10
782 => 9
918 => 17


Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int a1 = n/10;
int a2 = a1*10;
int a3 = n - a2;
Console.WriteLine(a3);
*/
Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());

if (n>99 && n < 1000)
{Console.WriteLine(n % 10);}
else
{Console.WriteLine("Число введено неверно");}