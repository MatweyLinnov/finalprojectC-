                  
int m = InputNum("Введите M: ");                                         //         | n+1               m = 0
int n = InputNum("Введите N: ");                                         // A(m,n) =| A(m-1, 1)         m > 0, n = 0
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");                    //         | A(m-1, A(m,n -1)) m > 0, n > 0

int InputNum( string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}