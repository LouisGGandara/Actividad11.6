// Determinar el menor de tres números utilizando una función MenorDeTres(int a, int b, int c) que retorne el valor menor.

using System.ComponentModel;

static int MenorDeTres(int a, int b, int c )
{
    if (a < b && a < c)
    {
        return a;
    } else if (b < a && b < c)
    {
        return b;
    } else
    {
        return c;
    }
}

MenorDeTres(3, 7, 1);