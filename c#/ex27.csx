/*27. Implementar uma função que separe os caracteres de um texto por hífen. */

public string SeparatorUltraThreeThousand(string phrase, string symbol)
{
    string rsp = "";
    for (int i = 0; i < phrase.Length; i++)
    {
        if (i == phrase.Length - 1) rsp += phrase[i];
        else rsp += phrase[i] + symbol;
    }
    return rsp;
}

public void Main()
{
    try
    {
        Console.Write("Separar caracteres\nInsira o texto: ");
        string text = Console.ReadLine();
        Console.Write("Insira o símbolo: ");
        string symbol = Console.ReadLine();
        Console.WriteLine(SeparatorUltraThreeThousand(text, symbol));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();