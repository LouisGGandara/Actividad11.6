// Calcular la suma de los números del 1 hasta N utilizando una función SumarDel1AlN(int n).

static void SumarDel1AlN(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    Console.WriteLine($"Suma es: {sum}");
}

SumarDel1AlN(3);