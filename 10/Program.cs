// Imprimir un texto varias veces utilizando una función ImprimirRepetido(string texto, int veces).

static void ImprimirRepetido(string texto, int veces)
{
    for (int i = 0; i < veces; i++)
    {
        Console.WriteLine(texto);
    }
}

ImprimirRepetido("WiggyWaggy", 5);