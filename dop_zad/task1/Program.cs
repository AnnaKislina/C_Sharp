Console.Clear();

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

/* Задача . В заданной строке текста определите 
количество слов. Каждое слово отделено друг от друга пробелом.*/

/* System.Console.WriteLine("Введите что нибудь");
string st = Console.ReadLine();
int count = 0;

for (int i = 0; i < st.Length; i++)
{
    if (st[i] == ' ') count++;
}
System.Console.WriteLine(count);
 */
//--------------------------------------------------------------
/* В массиве строк (список фамилий) определите самую длинную фамилию. */

/* string[] array = ["Петров","Иванов","Сидоров","Путин","Копиленов"];

int maxInd = 0;
int maxDl = array[0].Length;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length > maxDl)
    {
        maxInd = i;
        maxDl = array[i].Length;
    }
}
System.Console.WriteLine(array[maxInd]); 
 */
//-----------------------------------------
/* for(int i = 0; i < stringArray.Length; i++)
{
   stringArray[i] = Console.ReadLine();

} */
//------------------------------------------
//------------------------------------------
//------------------------------------------