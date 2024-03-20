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
/*
string num1 = "";
int num2;
List<int> Spisok = new List<int>();

while (true) // Бесконечный цикл
{   int sum = 0;
    Console.WriteLine("Введите элемент массива");
    num1 = Console.ReadLine();
    if (num1 == "q") // Проверка на q
        {
        break;
        }
    int.TryParse(num1, out num2); // преобразуем из стринга в инт
    Spisok.Add(num2); // записываем в список
    while (num2 > 0) //проверка на четность суммы цифр
        {sum =sum + num2 % 10; 
        num2 = num2 / 10;} 
    if (sum % 2 == 0) {break;}
    
    foreach (int item in Spisok) //вывод списка
    {
       Console.Write($"{item} ,"); 
    }
    Console.WriteLine();
}
*/
//---------------------------------------------------------------------
//---------------------------------------------------------------------
/* Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/
//--------Решение-------
void FillArray (int start, int end, int[] arr)
{
for (int i = 0; i < arr.Length ; i++)
{
    arr[i] = new Random().Next (start, end);
 }    
}

int CountEven (int[] arr)
{
    int rezult = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {rezult++;}
    }
    return rezult;
}
/*
int [] user_arr = new int [10];
FillArray(100,1000,user_arr);
PrintArray(user_arr);
System.Console.WriteLine(CountEven(user_arr));
*/
//---------------------------------------------------------------------
//---------------------------------------------------------------------
/* Задача 3: Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.) */
void ReversArray(int[] array)
{ int n = 0;
 for (int i = 0; i < array.Length/2; i++)
 {
    n = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = array[i];
    array[i] = n;
 } 
 }

int[] user_arr = new int[10];
FillArray(1,10,user_arr);
PrintArray(user_arr);
ReversArray(user_arr);
PrintArray(user_arr);