
/*
Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа
должна выдать ответ: Да/Нет.
Примеры
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да 
*/
/*
int[] array = {1, 3, 4, 19, 3};
Console.Write("Введите число для поиска: ");
int x = Convert.ToInt32(Console.ReadLine()); 
int v = 0;

foreach (int e in array)
{
    if (e == x) {v = x;}
}


for (int i = 0; i < array.Length ; i++)
{     if (array[i] == x) {v = x;}
}

if (v == x)
{Console.Write("Да");}
else {
Console.Write("Нет");}
------------------------
*/
/*
Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6]

int[] arr = new int[10];
for (int i = 0; i < 10 ; i++)
{
    arr[i] = new Random().Next (-10, 11);
    Console.Write($"arr [{i}] = {arr[i]} ; ");
}
System.Console.WriteLine();

for (int i = 0; i < 10 ; i++)
{
    arr[i] = arr[i] * -1;
    Console.Write($"{arr[i]} ");
}
------------------------------------------------------
*/

Найдите произведения пар чисел в одномерном массиве. Парой
считаем первый и последний элемент, второй и предпоследний и
т.д. Результат запишите в новый массив.
Пример
[1 3 2 4 2 3] => [3 6 8]
[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int r = new Random().Next (1, 11);
int[] arr = new int[r];
for (int i = 0; i < arr.Length ; i++)
{
    arr[i] = new Random().Next (1, 11);
    Console.Write($"{arr[i]} ");
}
System.Console.WriteLine();

int[] arr2 = new int[r/2];
for (int i = 0; i < arr.Length/2 ; i++)
{
    arr2[i] = arr[i] * arr[arr.Length-i-1];
    Console.Write($" {arr2[i]} ");
}



/*
Дано натуральное трёхзначное число. Создайте массив, состоящий из
цифр этого числа. Младший разряд числа должен располагаться на 0-
м индексе массива, старший – на 2-м.
Пример
456 => [6 5 4]
781 => [1 8 7]


int n = new Random().Next (100,1000);
Console.WriteLine(n);
int[] arr3 = new int[3];
for (int i = 0; i < arr3.Length ; i++)
{
    arr3[i] = n % 10;
    Console.Write($" {arr3[i]} ");
    n = n/10;
}
--------------------------------------
*/
