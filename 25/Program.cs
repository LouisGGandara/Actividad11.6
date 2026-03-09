// Determinar si un número es primo utilizando una función EsPrimo(int n) que retorne verdadero o falso.

static bool EsPrimo(int n)
{
    bool prime = true;
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            prime = false;
            break; 
        }
    }
    return prime;
}

EsPrimo(8);