
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

*/

/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно

*/
Console.WriteLine("Введите 2 числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 ==0)
{
 Console.WriteLine("кратно");   
}
else { Console.WriteLine("некратно "+num1 % num2); }