int m = InputNum("Введите M: ");
int n = InputNum("Введите N: ");


int InputNum(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}


int CountNaturalSum(int m, int n)
{
    if (m == n)
    {
        return n;
    }
     return n + CountNaturalSum(m, n - 1);
    
}
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

