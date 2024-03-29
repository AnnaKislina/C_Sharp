Console.Clear();

/* Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр. */

/* int SumNumb (int num)  //356   35  3   0
{
    if (num == 0)
    {
        return 0;
    }
    else
    {
        return num % 10 + SumNumb(num / 10); //  6  +  5   +  3
    }
}

System.Console.WriteLine(SumNumb(356)); */

//----------------------------------------------------------------

/* Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N. */

/* int n = Convert.ToInt32(Console.ReadLine());
IntegersN (n);

void IntegersN (int n, int count = 1)
{
    if (n < count)
    {
        return;
    }
    else
    {
        System.Console.WriteLine(count);
        IntegersN(n, count + 1 );
    }
} 

void IntegersN (int n)
{
    if (n < 1)
    {
        return;
    }
    else
    {
        IntegersN(n-1);
        System.Console.WriteLine(n);     
    }
}

 */
 //-----------------------------------------------------------------
/* 
 Напишите программу, которая на вход принимает два числа A и B, 
 и возводит число А в целую степень B с помощью рекурсии. */

/*  int PowUser (int a, int b)
 {
    if (b == 1)
    {
        return a;
    }
    else
    {
        return a * PowUser(a, b - 1);
    }
 }

 System.Console.WriteLine(PowUser(2,3)); */

 //-----------------------------------------------------------------

/*  Считать строку с консоли, содержащую латинские буквы.
Вывести на экран согласные буквы этой строки. */

string st = Console.ReadLine();
char[] glas = {'a','e','i','u','y','o'};
PrintGlas(st, glas , 0);

void PrintGlas (string st, char[] arr, int i)
{
    if (i == st.Length) 
    {
        return;
    }
    else
    {   
        for (int j = 0; j < arr.Length; j++)
        {
            if (st[i] == arr[j]) 
            {
                System.Console.WriteLine(st[i]);
            }  
        } 
        PrintGlas(st, arr, i = i + 1);
    }
}

