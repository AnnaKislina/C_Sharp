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
    if (arr[i] >= 20 && arr[i] <= 90)
        {count = count + 1;}
}
System.Console.WriteLine();
System.Console.WriteLine(count);
*/
/*------------ЗАДАНИЕ ИЗ АВТОТЕСТОВ----------------------------------------*/
/*
using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
      int count = 0;
      for (int i = 0; i < numbers.Length ; i++)
        { if (numbers[i] >= minRange && numbers[i] <= maxRange)
                {count = count + 1;}
         }
      return count;
     }

    public static void PrintResult(int[] array)
    {int count =CountItemsRange(array, 10, 90) ;
     Console.Write(count);
    }
}


//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();

            // Теперь arr содержит преобразованные в целые числа из командной строки
        } else {
           // Если аргументов на входе нет
            array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}
*/
/*----------------------------------------------------*/
/*----------------------------------------------------*/
/*----------------------------------------------------*/
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
/*------------из автотестов------------------------------------------*/
/*
class UserInputToCompileForTest
{ 
    // Подсчет количества четных элементов массива
    // numbers - массив, в котором ведется подсчет
    public static int CountEvenItems(int[] numbers)
    {
      int count = 0;
      for (int i = 0; i < numbers.Length ; i++)
          {if (numbers[i] % 2 == 0){count = count + 1;}}     
      return count;
    }
    
    public static void PrintResult(int[] array)
    {int count =CountEvenItems(array) ;
     Console.Write(count);
    }
}
*/
/*------------------------------------------------------*/
/*------------------------------------------------------*/
/*------------------------------------------------------*/
/*------------------------------------------------------*/
/*
Задача 3: Задайте массив из вещественных чисел с
ненулевой дробной частью. Найдите разницу между
максимальным и минимальным элементов массива. 
-----
double[] arr = new double[10];
double max = arr [0];
double min = 10;

for (int i = 0; i < arr.Length ; i++)
{
    arr[i] = new Random().NextDouble () *10;
    Console.WriteLine($"{arr[i]} ");
    if (arr[i] > max) {max = arr[i];}
    if (arr[i] < min) {min = arr[i];}
}
System.Console.WriteLine();
System.Console.WriteLine($"max - min = {max - min}");
*/
/*------------из автотестов-----------------------------------------------*/
/*
class UserInputToCompileForTest
{    
    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {double min = numbers[0];
      for (int i = 0; i < numbers.Length ; i++)
          {if (numbers[i] < min) {min = numbers[i];}}
     return min;
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {double max = numbers[0];
      for (int i = 0; i < numbers.Length ; i++)
        {if (numbers[i] > max) {max = numbers[i];}}
     return max;
    }
  
    public static void PrintResult(double[] array)
    {   double max = FindMax(array);
        double min = FindMin(array);
        double rezult = max - min;
        Console.WriteLine(rezult);
    }
}
*/
/*-----------------------------------------------------------*/
/*-----------------------------------------------------------*/
/*-----------------------------------------------------------*/
/*
Задача 4**(не обязательно): Дано натуральное
число в диапазоне от 1 до 100 000. Создайте массив,
состоящий из цифр этого числа. Старший разряд
числа должен располагаться на 0-м индексе
массива, младший – на последнем. Размер массива
должен быть равен количеству цифр.
*/
int n = new Random().Next (1,100001);
Console.WriteLine(n);
int dl = n.ToString().Length;
int[] arr = new int[dl];

/* Первый вариант
for (int i = 0; i < dl ; i++)
{
    arr[dl-i-1] = n % 10;
    n = n / 10;
}
*/

/*Второй вариант*/
for (int i = 0; i < dl ; i++)
{
    arr[i] = n % 10;
    n = n / 10;
}
Array.Reverse(arr);

//Вывод массива
for (int i = 0; i < dl ; i++)
{    Console.Write($" {arr[i]} ");}

