/* Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы. */

void IntegersN(int n, int m)
{
    if (n < m)
    {
        return;
    }
    else
    {
        System.Console.Write($"{m} ");
        IntegersN(n, m + 1);
    }
}

System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
IntegersN(n, m);