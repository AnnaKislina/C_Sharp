/* See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Напишите программу, 
которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N. 

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
long i = 0 ;

for (i = -n ; i<=n ; i++)
{
   Console.Write(i+" ");
}

