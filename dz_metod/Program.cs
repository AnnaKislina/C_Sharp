/* Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.*/
//--------Решение-------

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] arr = new int[1];
int size = 0;
var num = 0;

void FillArray (int[] arr, int saze_fill)
{
System.Console.WriteLine("Введите элемент массива");
arr[saze_fill] = Convert.ToInt32(Console.ReadLine());
//return arr;  
}

while (num != "q" )
{
    FillArray(arr, size);
    PrintArray(arr);
    size = size + 1;
}