// Contar la cantidad de vocales dentro de un texto utilizando una función ContarVocales(string texto).

static void ContarVocales(string texto)
{
    int count = 0;
    texto = texto.ToLower();
    for (int i = 0; i < texto.Length; i++)
    {

        if (texto[i] == 'a' || texto[i] == 'e' || texto[i] == 'i' || texto[i] == 'o' || texto[i] == 'u')
        {
            count++;
        }
    }
    Console.WriteLine($"Hay {count} vocales en su texto.");
}

ContarVocales("Hola mundo!"); // 4