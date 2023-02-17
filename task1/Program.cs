int n = InputNum("Введите положительное число N ");
while (n < 0)
{
    Console.WriteLine("Ввели не положительное число");
    n = InputNum("Введите положительное число N ");
}
int m = InputNum("Введите положительное число M ");
while (m < 0)
{
    Console.WriteLine("Ввели не положительное число");
    m = InputNum("Введите положительное число M ");
}
if (m % 2 != 0) m++;

if (n % 2 != 0)
{
    n--;
}
Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
    {
        return n;
    }
    else if (m % 2 == 0)
    {
        Console.Write($"{(m + 2)}, ");
        NaturalNumber(n, m + 2);
    }
    return m;
}

int InputNum(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}
