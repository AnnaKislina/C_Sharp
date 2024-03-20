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
