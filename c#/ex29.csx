/* Implementar uma função que verifique se todas as vogais aparecem em um texto. */

public bool NiceBoi(string phrase)
{
    int a = 0;
    int e = 0;
    int i = 0;
    int o = 0;
    int u = 0;
    phrase = phrase.ToLower();
    for (int ii = 0; ii < phrase.Length; ii++)
    {
        if (phrase[ii] == 'a') a = 1;
        if (phrase[ii] == 'e') e = 1;
        if (phrase[ii] == 'i') i = 1;
        if (phrase[ii] == 'o') o = 1;
        if (phrase[ii] == 'u') u = 1;
    }
    return a + e + i + o + u == 5 ? true : false;
}

public void Main()
{
    try
    {
        Console.Write("Verificar se todas as vogais aparecem\nInsira o texto: ");
        string text = Console.ReadLine();
        Console.WriteLine(NiceBoi(text));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();