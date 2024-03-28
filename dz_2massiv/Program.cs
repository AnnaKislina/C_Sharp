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

void ReversOneLast (int[,] arr) //поменять местами 1 ипоследнюю строку
{
    int r = arr.GetLength(0); // строки
    int c = arr.GetLength(1); // столбцы
    int[] arr1 = new int[c];

    for (int i = 0; i < arr.GetLength(1) ; i++)
    {arr1[i]= arr[r-1,i];}

    for (int j = 0; j < arr.GetLength(1) ; j++)
    {arr[r-1,j]= arr[0,j];
    arr[0,j]= arr1[j];
    }
}


/* int[,] table = Fill2Array(3,3);
Print2Array(table);
System.Console.WriteLine("поменяли 1 и последнюю строку");
ReversOneLast(table);
Print2Array(table); */

//---------------------------------------------------------------------------
//---------------------------------------------------------------------------
/* Задача 3: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с
наименьшей суммой элементов. */

int IndexMin2Array (int[,] arr) //поиск строки с мин элементом
{
    int index = 0;
    int min = arr[0,0];
    for (int i = 0; i < arr.GetLength(0) ; i++)
    {
        for (int j = 0; j < arr.GetLength(1) ; j++)
        {
            if (min > arr[i,j]) {index = i;}
        } 
    }
return index;
}

/* int[,] table = Fill2Array(3,4);
Print2Array(table);
System.Console.WriteLine($"Строка с мин = {IndexMin2Array(table)}");*/

//---------------------------------------------------------------------------
//---------------------------------------------------------------------------
/* Задача 4*(не обязательная): Задайте двумерный массив
из целых чисел. Напишите программу, которая удалит
строку и столбец, на пересечении которых расположен
наименьший элемент массива. Под удалением
понимается создание нового двумерного массива без
строки и столбца */

/*int[,] DelStrStolbMin (int[,] arr) //удалит строку и столбец с мин
{   int[,] arr2 = new int[arr.GetLength(0)-1,arr.GetLength(1)-1];
    int index_i = 0;
    int index_j = 0;
    int min = arr[0,0];
    for (int i = 0; i < arr.GetLength(0) ; i++) //нахождение индексов
    {
        for (int j = 0; j < arr.GetLength(1) ; j++)
        {
            if (min > arr[i,j]) {index_i = i; index_j = j;}
        } 
    }
    for (int i = 0; i < index_i ; i++)
    {
        for (int j = 0; j < index_j ; j++)
        {arr2[i,j] = arr[i,j];} 
    }
    for (int i = index_i+1 ; i < arr.GetLength(0) ; i++)
    {
        for (int j = index_j+1; j < arr.GetLength(1) ; j++)
        {arr2[i,j] = arr[i,j];} 
    }    
return arr2;
}
*/

int[,] table = Fill2Array(3,3);
Print2Array(table);
int[,] table2 = DelStrStolbMin(table);
System.Console.WriteLine();
Print2Array(table2);





//---------------------------------------------------------------------------
/*------------ЗАДАНИЕ ИЗ АВТОТЕСТОВ----------------------------------------*/
//---------------------------------------------------------------------------
/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет: 
"Позиция по рядам выходит за пределы массива"
или
"Позиция по колонкам выходит за пределы массива"

Позиции в массиве считать от единицы. */
/*
class UserInputToCompileForTest
{ 
// Поиск элемента по позициям
    public static int FindElementByPosition(int[,] array, int x, int y)
    { 
      int num = array[x-1,y-1];
      return num;
    }
// Проверка позиций на вхождение в массив
    public static bool ValidatePosition(int[,] array, int x, int y)
    { bool status = false;
      if(x < array.GetLength(0) && y < array.GetLength(1))
      {status = true;}
      return status;
    }

  public static void PrintResult(int[,] numbers, int x, int y)
    {
        if (ValidatePosition(numbers,x,y))
        {Console.WriteLine(FindElementByPosition(numbers,x,y));}
        if(x > numbers.GetLength(0))
         {Console.WriteLine("Позиция по рядам выходит за пределы массива");}
         if(y > numbers.GetLength(1))
         {Console.WriteLine("Позиция по колонкам выходит за пределы массива");}
           
    }
}
*/



//------------------------------------------------------------------
//------------------------------------------------------------------
/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить 
строку с наименьшей суммой элементов. */
class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    { 
      int[] arr = new int[array.GetLength(0)];
      for (int i = 0; i < array.GetLength(0) ; i++)
      {  int sum = 0;
         for (int j = 0; j < array.GetLength(1) ; j++)
         {
            sum = sum + array[i,j];
         } 
         arr[i] = sum;
       }
       return arr;
    }
    
    // Получение индекса минимального элемента в одномерном массиве
    public static int MinIndex(int[] array)
    {  int minIndx = 0 ;
       int min = array[0];
       for (int i = 0; i < array.Length; i++)
       {
           if (array[i] < min)
           {
             minIndx = i;
             min = array[i];
           }
       }
     return minIndx;
    }
 
    public static void PrintResult(int[,] numbers)
    {  
      int[] arr = SumRows(numbers);
      int minI = MinIndex(arr);
       Console.WriteLine(minI); 
    }
}

//------------------------------------------------------------------
//------------------------------------------------------------------
/* Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива. */

class UserInputToCompileForTest
{
    // Печать массива
    public static void PrintArray(int[,] array)
    {
       for (int j = 0; j < array.GetLength(0); j++)
      {
          for (int i = 0; i < array.GetLength(1); i++)
          {
              Console.Write($"{array[j, i]}\t");
           }
        Console.WriteLine();
       }
     }

// Обмен первой с последней строкой
    public static int[,] SwapFirstLastRows(int[,] array)
    {   

      for (int j = 0; j < array.GetLength(0); j++)
      {
          for (int i = 0; i < array.GetLength(1); i++)
          {
              SwapItems(array, i);     
           }
       }
      int[,] arrRezult = array;
       return arrRezult;
    }

// Обмен элементами массива
    public static void SwapItems(int[,] array, int i)
    {
      var tmp = array[array.GetLength(0) - 1, i];
      array[array.GetLength(0) - 1, i] = array[0, i];
      array[0, i] = tmp;
    }

    public static void PrintResult(int[,] numbers)
    {
       int[,] arr = SwapFirstLastRows(numbers);
       PrintArray(arr);
    }
}

