/* Задача 2: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n. */

int A(int n, int m)
{
    if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
    if (n == 0) return m + 1;
    if (m == 0) return A(n - 1, 1);
    return A(n - 1, A(n, m - 1));
}

System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());    
Console.WriteLine($"Функция Аккермана А({n},{m}) = {A(n, m)}");



