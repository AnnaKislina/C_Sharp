/* Задача 4*(не обязательная): Задайте двумерный массив
из целых чисел. Напишите программу, которая удалит
строку и столбец, на пересечении которых расположен
наименьший элемент массива. Под удалением
понимается создание нового двумерного массива без
строки и столбца */
Console.Clear();


int[,] Get2DArray(int row, int column) //рандом 2-массива
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)  //печать 2-массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

(int, int) FiendMinIndex (int[,] array)  //индексы минимального значения
{
    int minRow = 0;
    int minCol = 0;
    int min = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          if (array[i,j] < min)
          {
            minRow = i;
            minCol = j;
            min = array[i,j];
          }   
        }
    }
    return (minRow, minCol);
}

/* int[,] DelColRow (int[,] array, int row, int col);
{
    int[,] arrRezult = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int x = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        if (i == row)
        {
            row = -1;
            continue;
        }
        int y = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == col)
            {
                continue;
            }
            arrRezult[x,y]= array[i,j];
            y++;
        }
        x++;
    }
    return arrRezult;
}*/

int[,] DeleteMinColumnRow(int[,] array, int row, int column)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int x = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == row)
        {
            continue;
        }
        int y = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == column) continue;
            result[x, y] = array[i, j];
            y++;
        }
        x++;
    }
    return result;
} 


int[,] userArray = Get2DArray(4,4);
Print2DArray(userArray);
(int minRow, int minCol) = FiendMinIndex(userArray);
System.Console.WriteLine($"{minRow}  {minCol}");
int[,] newArray = DeleteMinColumnRow(userArray,minRow,minCol);
System.Console.WriteLine();
Print2DArray(newArray);
