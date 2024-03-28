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

void Print2Array(char[,] arrayToPrint) // печать char 2-массива
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

char[,] FillChar2Array (int row, int colum) //рандом char 2-массива
{
Random rnd = new Random();
char[,] ch_arr = new char[row,colum];

for (int i = 0; i < ch_arr.GetLength(0) ; i++)
{
   for (int j = 0; j < ch_arr.GetLength(1) ; j++)
   {
     ch_arr[i,j]=(char) rnd.Next('a', 'z');
   } 
}
return ch_arr;
}

//------------------------------------------------------------------
/* Задача 1: Задайте двумерный массив символов (тип char
[,]). Создать строку из символов этого массива.  */

/*
string ArrVString (char[,]arrayChar)
{
    string stUser = "";
    for (int i = 0; i < arrayChar.GetLength(0); i++)
    {
        for (int j = 0; j < arrayChar.GetLength(1); j++)
        {
          stUser =  stUser + arrayChar[i,j];  
        }
    }
    return stUser;
}

char[,] ch_arr_user = FillChar2Array(3,5);
Print2Array(ch_arr_user);
string stUser = ArrVString(ch_arr_user);
System.Console.WriteLine(stUser); 
*/

//------------------------------------------------------------------
/* Задача 2: Задайте строку, содержащую латинские буквы
в обоих регистрах. Сформируйте строку, в которой все
заглавные буквы заменены на строчные */

/* System.Console.WriteLine("Введите строку: ");
string stUser = Console.ReadLine();
string strRezult = "";
strRezult = stUser.ToLower();
System.Console.WriteLine(strRezult); */

//------------------------------------------------------------------
/* Задача 3: Задайте произвольную строку. Выясните,
является ли она палиндромом. */
/* System.Console.WriteLine("Введите строку: ");
string stUser = Console.ReadLine();
int coun = 0;
ProverkaPolid(stUser);

void ProverkaPolid (string stUser)
{
    for (int i = 0; i < stUser.Length/2; i++)
    {
        if (stUser[i] == stUser[stUser.Length-1-i])
        {coun++;}
    }
    if (coun == stUser.Length/2)
    {System.Console.WriteLine("Да");}
    else 
    {System.Console.WriteLine("Нет");}
} */

//----------------------------------------------------------------------
//------------------------------------------------------------------------
Задача 4 (необязательная): Обратный порядок слов в строкеpublic class Task4
{
public static void Main(string[] args)
{
// Входная строка со словами, разделенными пробелами
string input = "Hello my world";
// Вызов метода для обращения порядка слов в строке
string result = ReverseWords(input);
// Вывод результата
Console.WriteLine(result);
}
// Метод для обращения порядка слов в строке
public static string ReverseWords(string str)
{
// Разделение строки на слова
string[] words = str.Split(' ');
// Обращение порядка слов
Array.Reverse(words);
// Соединение слов обратно в строку с пробелами
return string.Join(" ", words);
}
}