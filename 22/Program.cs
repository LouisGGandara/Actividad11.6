// Repetir un texto varias veces utilizando una función Repetir(string texto, int veces) que retorne el texto repetido.

static void Repetir(string texto, int veces)
{
    for (int i = 0; i < veces; i++)
    {
        Console.WriteLine($"{texto}");
    }
}

Repetir("Hola", 4);