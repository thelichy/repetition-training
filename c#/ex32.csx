/*32. Implementar uma função que inverta os caracteres de um texto recebido. */

public string Inverter(string phrase)
{
    string rsp = "";
    for (int i = phrase.Length - 1; i >= 0; i--)
    {
        rsp += phrase.Substring(i, 1);
    }
    return rsp;
}

public void Main()
{
    try
    {
        Console.Write("Inverter os caracteres\nInsira o texto: ");
        string text = Console.ReadLine();
        Console.WriteLine(Inverter(text));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();