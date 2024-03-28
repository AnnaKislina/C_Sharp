/*
Задайте одномерный массив, заполненный случайными целыми
числами. Определите количество четных чисел в этом
массиве.
*/
/*
void FillArray (int start, int end, int[] arr)
{
for (int i = 0; i < arr.Length ; i++)
{
    arr[i] = new Random().Next (start, end);
 }    
}

void PrintArray (int[] arr)
{
for (int i = 0; i < arr.Length ; i++)
{
System.Console.Write($"{arr[i]} ");
 }    
---------------------------------------------------------------------------------}*/

int CountEven (int[] arr)
{
    int rezult = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) 
        {
            rezult++;
        }    
    }
    return rezult;
}

int [] user_arr = new int [10];
FillArray (1, 100, user_arr);
PrintArray (user_arr);
System.Console.WriteLine();
System.Console.WriteLine(CountEven(user_arr));
int count = CountEven (user_arr);
System.Console.WriteLine(count);
-------------------------------------------------------------------------------*/
/* Задайте массив из N случайных целых чисел (N вводится с
клавиатуры).
Найдите количество чисел, которые делятся нацело на 7 */

int[] FillArray (int size)
{
System.Console.WriteLine("Заполните массив");
int[] arr = new int [size];
for (int i = 0; i < arr.Length ; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
 }  
 return arr;  
}

/*
System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] user_arr = new int [size];
FillArray(user_arr);

int CountEven (int[] arr)
{
    int rezult = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 7 == 0)
        {rezult++;}
    }
    return rezult;
}
 */
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

/* printArray(user_arr);
System.Console.WriteLine(CountEven(user_arr)); */
//------------------------------------------------------------------------
/* Заполните массив на N (вводится с консоли, не более 8)
случайных целых чисел от 0 до 9.
Сформируйте целое число, которое будет состоять из цифр из
массива. Старший разряд числа находится на 0-м индексе,
младший – на последнем.
Пример
[1 3 2 4 2 3] => 132423
[2 3 1] => 231 */

/* int[] user_arr= FillArray(8);
PrintArray(user_arr);

int GetNumber (int[] arr)
{
    int rezult = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        rezult = rezult * 10 + arr [i];
    }
    return rezult;
}
System.Console.WriteLine(GetNumber(user_arr)); */

int[] array = FillArray(5);
PrintArray(array);