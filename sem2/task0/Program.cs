/*
Напишите программу, которая принимает на
вход трёхзначное число и удаляет вторую
цифру этого числа.
Примеры
a = 256 => 26
a = 891 => 81


Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
int n1 = num / 100 ;
int n2 = num % 10;
Console.WriteLine(n1 * 10 + n2);
}
else {Console.WriteLine("Число не являеться трехзначным");}
*/


