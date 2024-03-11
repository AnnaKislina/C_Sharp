
/*
Напишите программу, которая выводит случайное число из отрезка
 [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8


int num = new Random().Next (10, 100);
Console.WriteLine(num );
if (num / 10 > num % 10)
{
  Console.WriteLine(num / 10);
}
else 
{Console.WriteLine(num % 10);}
--------------------------------------------------------
*/
/*
Напишите программу, которая выводит случайное 
трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98

int num = new Random().Next (100, 1000);
Console.WriteLine(num );

int num1 = num / 100;
int num2 = num % 10;
Console.WriteLine(num1 *10 + num2);
---------------------------------------------------------------------
*/

/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно


Console.WriteLine("Введите 2 числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 ==0)
{
 Console.WriteLine("кратно");   
}
else { Console.WriteLine("некратно "+num1 % num2); }
----------------------------------------------------------
*/
/*
14. Напишите программу, которая принимает на вход число
 и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 ==0)
{
    Console.WriteLine("да");
}
else {    Console.WriteLine("нет");}
----------------------------------------------------------------------
*/
/*
Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет


Console.WriteLine("Введите 2 числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());


if (Math.Pow(num1, 2) == num2 || Math.Pow(num2, 2) == num1 )
{ 
 Console.WriteLine("Да");   
}
 else {Console.WriteLine("Нет");}
--------------------------------------------------------
*/
/*
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт 
номер координатной четверти плоскости, в которой находится эта точка.

 Console.Write("Введите координаты точки X и Y через пробел:");string[] coordinates = Console.ReadLine().Split(' ');
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);
if (x > 0 && y > 0)
Console.WriteLine("1");
else if (x < 0 && y > 0)
Console.WriteLine("2");
else if (x < 0 && y < 0)
Console.WriteLine("3");
else if (x > 0 && y < 0)
Console.WriteLine("4");
else
Console.WriteLine("Точка находится на ")ж
-----------------------------------------------------------------
*/
/*
Напишите программу, которая на вход принимает натуральное число N, 
а на выходе показывает его цифры через запятую.

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{Console.WriteLine(N);}
else {
    while (N > 0)
    {
    int currentDigit = N % 10;
    N /= 10;
        f (N > 0)
        {Console.Write(currentDigit + ",");
     }
else
{
Console.WriteLine(currentDigit);
}
*/