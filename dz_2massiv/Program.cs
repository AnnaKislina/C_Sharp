/* Задача 1: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет. */



int[,] Fill2Array (int row, int colum) //рандом 2-массива
{
Random rnd = new Random();
int[,] arr = new int[row,colum];

for (int i = 0; i < arr.GetLength(0) ; i++)
{
   for (int j = 0; j < arr.GetLength(1) ; j++)
   {
    arr[i,j]= rnd.Next(1,11);
   } 
}
return arr;
}


void Print2Array(int[,] arrayToPrint) // печать 2-массива
{for (int j = 0; j < arrayToPrint.GetLength(0); j++)
    {Console.Write("[");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
        {
            Console.Write(arrayToPrint[j,i]);
            if (i != arrayToPrint.GetLength(1) - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write("]");
        Console.WriteLine();
    }
}
/*
int PoiskPoIndex (int i, int j, int[,] arr) //поиск элемента по индексам в 2мас
{   int n = arr[i,j];
    return n;
}

public IndexOutOfRangeException(string "Ошибка", Exception innerException);
int[,] table = Fill2Array(3,3);
Print2Array(table);
System.Console.WriteLine(PoiskPoIndex(3,2,table));
*/

//---------------------------------------------------------------------------
//---------------------------------------------------------------------------
/* Задача 2: Задайте двумерный массив. Напишите
программу, которая поменяет местами первую и
последнюю строку массива. */

int[,] ReversOneLast (int[,] arr) //поменять местами 1 ипоследнюю строку
{
int[]
for (int i = 0; i < arr.GetLength(0) ; i++)
{
   for (int j = 0; j < arr.GetLength(1) ; j++)
   {
    arr[i,j]= rnd.Next(1,11);
   } 
}
return arr;
}


int[,] table = Fill2Array(3,3);
Print2Array(table);
System.Console.WriteLine("поменяли 1 и последнюю строку");

