// Создание двумерного массива 3*5 и вывести на экран

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

   
void PrintArray(int[] arrayToPrint)   // печать 1-массива
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
//int[,] table = Fill2Array(3,5);
//Print2Array(table);
//-----------------------------------------------------------

bool Chet_NeChet(int num)   // нроверка суммы цифр числа на четность
{   bool rezult = false;
    int sum = 0; 
    while (num > 0) 
        {sum =sum + num % 10; 
        num = num / 10;} 
    if (sum % 2 == 0) 
    {rezult = true;}
    else {rezult = false;}
    return rezult;
}

/* int[,] table = Fill2Array(3,5);
Print2Array(table);
foreach (int e in table)   
{if (Chet_NeChet(e))
    {System.Console.Write($"{e} ,");} 
}
 */

 //------------------------------------------
//------------СТРОКИ------------------------------
//------------------------------------------
string CreatString (string s)  // Возрощает только буквы из строки
{
   string letters  = "";
   foreach (char e in s) 
   {if (char.IsAsciiLetter(e) == true)
        {
          letters = letters + e;  
        }
   }
   return letters;
}

//System.Console.WriteLine("Введите строку");
//string st = Console.ReadLine();
//System.Console.WriteLine(CreatString(st));


string CreatStringNumb (string s)  // Возрощает только цыфры из строки
{
   string letters  = "";
   foreach (char e in s) 
   {if (char.IsAsciiDigit(e) == true)
        {
          letters = letters + e;  
        }
   }
   return letters;
}

int[] StrToArrInt (string str)    //Преобразует строку в массив чисел
{int[] arr = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        arr[i] = Convert.ToInt32(str.Substring(i, 1));
    }
    return arr;
}

System.Console.WriteLine("Введите строку");
string st = Console.ReadLine();
string st_numb = CreatStringNumb(st);
int[] arr_user = StrToArrInt(st_numb);
PrintArray(arr_user);