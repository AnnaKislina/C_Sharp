int[,] Fill2Array (int row, int colum)  //рандом 2-массива
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

void Print2DArray(int[,] arrayToPrint)  // печать 2-массива
{
    Console.Write($"[ ]\t");
    const int startIndex = 0;
    for (var i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{(i)}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i + "]\t");

        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


/* 1. Задайте двумерный массив. Найдите элементы, у которых оба
индекса чётные, и замените эти элементы на их квадраты. */
int[,] arr = Fill2Array(3,5);
Print2DArray(arr);
System.Console.WriteLine();
/*Print2DArray_New(arr); */

void Print2DArray_New(int[,] arrayToPrint)  // возведение в квдр чет индекс
{
    Console.Write($"[ ]\t");
    const int startIndex = 0;
    for (var i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{(i)}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i + "]\t");

        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {   
            if (i % 2 == 0 && j % 2 == 0)
            {
            Console.Write(Convert.ToInt32(Math.Pow(arrayToPrint[i, j],2)) + "\t");
            }
            else 
            {
            Console.Write(arrayToPrint[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}

//---------------------------------------------------------------------------
/* Задание 2. 
Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали (с индексами (0,0); (1;1) и
т.д. */

int SumDiagonal (int[,] arr)  // сумма диагонали
{
    int sum = 0 ;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {sum = sum + arr[i,j];}   
        }
    }
    return sum;
}

int sum = SumDiagonal(arr);
System.Console.WriteLine(sum);

//----------------------------------------------------------------------------------
/*Задание 3.
Задайте двумерный массив из целых чисел. Сформируйте новый
одномерный массив, состоящий из средних арифметических
значений по строкам двумерного массива. */

double[] SrArifmet(int[,] arr)  //Среднеарифметический по строкам
{   
    double[] arr_rezult = new double[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0) ; i++)
    {   int sum = 0;
        for (int j = 0; j < arr.GetLength(1) ; j++)
        {
            sum = sum + arr[i,j];
        } 
        arr_rezult[i] = sum / arr.GetLength(1); 
    }
    return arr_rezult;
}


