/*
Задача 1: Задайте одномерный массив из 10 целых
чисел от 1 до 100. Найдите количество элементов
массива, значения которых лежат в отрезке [20,90]. 
----

int[] arr = new int[10];
int count = 0;

for (int i = 0; i < arr.Length ; i++)
{
    arr[i] = new Random().Next (1, 101);
    Console.Write($"{arr[i]} ");
    if (arr[i] >= 10 && arr[i] <= 90)
        {count = count + 1;}
}
System.Console.WriteLine();
System.Console.WriteLine(count);
*/
/*----------------------------------------------------*/
/*
Задача 2: Задайте массив на 10 целых чисел.
Напишите программу, которая определяет
количество чётных чисел в массиве.
----
int[] arr = new int[10];
int count = 0;

for (int i = 0; i < arr.Length ; i++)
{
    arr[i] = new Random().Next (1, 10);
    Console.Write($"{arr[i]} ");
        if (arr[i] % 2 == 0)
        {count = count + 1;}
}    
System.Console.WriteLine();
System.Console.WriteLine(count);
*/
/*------------------------------------------------------*/
/*
Задача 3: Задайте массив из вещественных чисел с
ненулевой дробной частью. Найдите разницу между
максимальным и минимальным элементов массива. 
-----*/
double[] arr = new double[10];
double max = arr [0];
double min = arr [0];

for (int i = 0; i < arr.Length ; i++)
{
    arr[i] = new Random().Next (1, 10);
    Console.Write($"{arr[i]} ");
    if (arr[i] > max) {max = arr[i];}
    if (arr[i] < min) {min = arr[i];}
}
System.Console.WriteLine();
System.Console.WriteLine(max - min);