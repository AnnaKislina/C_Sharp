/* void OpenMatr (int size)
{
    if (size == 1)
    {
        System.Console.WriteLine("Слишком маленькая");
        return;
    }
    OpenMatr(size-1);
    System.Console.WriteLine($"Матрешка с размером - {size} "); 
}

OpenMatr(5); */
//--------------------------------------------------------------------
//факториал числа

int Factor(int n)
{
    if (n <= 1)
    {
        return 1;
    }
    System.Console.WriteLine(n);
    return n * Factor(n - 1);
}

System.Console.WriteLine(Factor(5)); 

//---------------------------------------------------------------------

