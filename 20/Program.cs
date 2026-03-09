// Contar la cantidad de caracteres de un texto utilizando una función ContarLetras(string texto).

static void ContarLetras(string texto)
{
    int count = texto.Length;
    Console.WriteLine($"Número de letras en '{texto}': {count}");
}

ContarLetras("palabra");