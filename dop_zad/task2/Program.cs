Console.Clear();

void PrintArray(char[] arrayToPrint) //печать char массива
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

char[] FillCharArray (int size) //рандом массива char
{
    Random rnd = new Random();
    char[] ch_arr = new char[size];
    for (int i = 0; i < ch_arr.Length ; i++)
    {
        ch_arr[i]=(char) rnd.Next('a', 'z');
    }
    return ch_arr;
}
//------------------------------------------------------------------
/* Задание 1. 
Задайте массив символов (тип char []). Создайте строку из
символов этого массива. */

/* char[] ch_arr_user = FillCharArray(5);
PrintArray(ch_arr_user);
//string stUser = string.Concat(ch_arr_user);
//string stUser = string.Join("", ch_arr_user);
string stUser = "";
for (int i = 0; i < ch_arr_user.Length; i++)
{
    stUser =  stUser + ch_arr_user[i];
}
System.Console.WriteLine(stUser); */

//-------------------------------------------------------------------
/* Задание 2. 
На основе символов строки (тип string) сформировать массив
символов (тип char[]). Вывести массив на экран. */

/* System.Console.WriteLine("Введите строку: ");
string stUser = Console.ReadLine();
char[] charArray = new char[stUser.Length];
for (int i = 0; i < stUser.Length; i++)
{
    charArray[i] = stUser[i];
}
PrintArray(charArray); */

//-------------------------------------------------------------------
/* Задание 3. 
Считать строку с консоли, состоящую из латинских
букв в нижнем регистре. Выяснить, сколько среди
введённых букв гласных. */

/* System.Console.WriteLine("Введите строку: ");
string stUser = Console.ReadLine();
char[] glas = new char[] {'a', 'e', 'i', 'u', 'y', 'o', 'j'};
int count = 0;
for (int i = 0; i < stUser.Length; i++)
{
    for (int j = 0; j < glas.Length; j++)
    {
        if (stUser[i] == glas[j])
        {
            count++;
        }
    }
}
System.Console.WriteLine(count); */

//-------------------------------------------------------------------
