/* Задание 1. Совместная работа
Задайте двумерный массив. Найдите элементы, у которых оба
индекса чётные, и замените эти элементы на их квадраты. */

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

void ChetVKvadr (int[,] arr)  //Возведение в квадрат четных индексов массива
{
    for (int i = 0; i < arr.GetLength(0) ; i++)
    {
        for (int j = 0; j < arr.GetLength(1) ; j++)
        {
            if (i % 2 == 0 && j % 2 ==0)
            {
                arr[i,j] = Convert.ToInt32(Math.Pow(arr[i,j],2));
            }
        } 
    }
}

/* int[,] arr_user = Fill2Array(3,5);
Print2Array(arr_user);
ChetVKvadr(arr_user);
System.Console.WriteLine("Преобразованный массив:");
Print2Array(arr_user); */
//--------------------------------------------------------
/* Задание 2. Работа в сессионных залах
Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали (с индексами (0,0); (1;1) и
т.д. */

int SumDiagonal (int[,] arr)  //Сумма чисел по главной диагонали
{   int sum = 0;
    for (int i = 0; i < arr.GetLength(0) ; i++)
    {
        for (int j = 0; j < arr.GetLength(1) ; j++)
        {
            if (i == j )
            {
                sum = sum + arr[i,j];
            }
        } 
    }
    return sum;
}

/*int[,] arr_user = Fill2Array(4,4);
Print2Array(arr_user);
System.Console.WriteLine ($"Сумма = {SumDiagonal(arr_user)}");*/
//--------------------------------------------------------
/*Задание 3. Совместная работа
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

void PrintArray(double[] arrayToPrint)   // печать 1-массива
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

int[,] arr_user = Fill2Array(3,5);
Print2Array(arr_user);
System.Console.WriteLine("Итоговый массив:");
PrintArray(SrArifmet(arr_user));


