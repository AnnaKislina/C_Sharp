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


