/*33. Implementar uma função que verifique se um texto é um palíndromo. */

public bool Palindromo(string words)
{
    string phrase = words.ToLower();
    string rsp = "";
    for (int i = phrase.Length - 1; i >= 0; i--) rsp += phrase[i];
    if (rsp.Replace(" ", "") == phrase.Replace(" ", "")) return true;
    else return false;
}

public void Main()
{
    try
    {
        Console.Write("Verificar se um texto é um palíndromo\nInsira o texto: ");
        string text = Console.ReadLine();
        Console.WriteLine(Palindromo(text));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();