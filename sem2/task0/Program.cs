/*
Напишите программу, которая принимает на
вход трёхзначное число и удаляет вторую
цифру этого числа.
Примеры
a = 256 => 26
a = 891 => 81
-----------
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


/*
Напишите программу, которая принимает на вход
трёхзначное число и возводит вторую цифру этого
числа в степень, равную третьей цифре.
Примеры
487 => 8^7 = 2 097 152
254 => 5^4 = 625
617 => 1
---------
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
int n1 = (num % 100 - num % 10 ) / 10;
int n2 = num % 10;
Console.WriteLine(Math.Pow(n1 , n2));
}
else {Console.WriteLine("Число не являеться трехзначным");}
*/


/*
Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если первое число некратно
второму, то программа выводит остаток от деления.
Примеры
14, 5 => нет, 4
16, 8 => да
4, 3 => нет, 1
*/
Console.WriteLine("Введите 2 числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
Console.WriteLine("Да");
}
else {Console.WriteLine("Нет, "+ num1 % num2);}