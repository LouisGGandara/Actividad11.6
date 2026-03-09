// Determinar si un número es múltiplo de otro utilizando una función EsMultiplo(int n, int m) que retorne verdadero o falso.

static bool EsMultiplo(int n, int m)
{
    if (n % m == 0)
    {
        return true;
    } else
    {
        return false; 
    }
}

EsMultiplo(90, 9);