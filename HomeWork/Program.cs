// Console.WriteLine("Введите натуральное число:");
// int m = Convert.ToInt32(Console.ReadLine());

// void RecursiveN(int m, int i = 1)
// {
//     if (m < i) return;

//     Console.WriteLine(i);
//     RecursiveN(m, i + 1);
// }
// RecursiveN(m);

Console.WriteLine("Задайте начальное значение");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
if (!isNumberM)
{
    Console.WriteLine("Не надо так!");
    return;
}

Console.WriteLine("Введите второе число");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
if (!isNumberN || n < m)
{
    Console.WriteLine("Не надо так!");
    return;
}
/*
void RecursiveMN(int m, int n) // Может высчитывать и для отрицательных чисел
{
    if (n - m == -1) return;

    Console.WriteLine(m);
    RecursiveMN(m + 1, n);
}
Console.WriteLine();
RecursiveMN(m, n);
*/
int SumOfNumbers(int m, int n)
{
    if (n - m == -1) return 0;
    return m + SumOfNumbers(m + 1, n);
}
Console.WriteLine(SumOfNumbers(m, n));

long AckermanFunction(int m, long n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return AckermanFunction(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
    else return n + 1;        
}
Console.WriteLine(AckermanFunction(m,n));