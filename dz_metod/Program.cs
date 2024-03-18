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

string num1 = "";
int num2;

List<int> Spisok = new List<int>();
int size = 0;

while (true) // Бесконечный цикл
{   int sum = 0;
    Console.Write("Введите элемент массива");
    num1 = Console.ReadLine();
    if (num1 == "q") // Проверка на ввод 'q' для выхода
        {
        break;
        }
    int.TryParse(num1, out num2);
    while (num2 > 0)
        {sum =sum + num2 % 10; 
        num2 = num2 / 10;} 
    if (sum % 2 == 0) {break;}

    //Spisok[0] = num2;

    Console.Write($"{num2} ");
}
