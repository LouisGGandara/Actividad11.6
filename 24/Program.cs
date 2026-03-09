// Calcular el factorial de un número utilizando una función Factorial(int n).

static void Factorial(int n)
{
    int total = 1;
    for (int i = 1; i <= n; i++)
    {
        total *= i;
    }
    Console.WriteLine($"Factorial de !{n} es: {total}");
}

Factorial(5);