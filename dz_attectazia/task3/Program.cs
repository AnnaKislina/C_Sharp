/* Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы. */



void PrintArray (int[] arr, int i = - 1)
{
    if ( i == arr.Length - 1)
    {
        return;
    }
    PrintArray(arr, i = i + 1);
    System.Console.Write($"{arr[i]} "); 
}

int[] arrUser = {1,2,3,4,5,6,7,8,9};
PrintArray(arrUser);
