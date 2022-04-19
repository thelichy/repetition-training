/* 36. Implementar uma função que converta uma palavra para ASCII. Dica: Use a função 
Convert.ToInt32(..) para C#, e charCodeAt(...) para JS. 
*/

public string WordToAscii(string word)
{
    string rsp = "";
    for (int i = 0; i < word.Length; i++) rsp += (Convert.ToInt32(word[i])) + " ";
    return rsp;
}

public void Main()
{
    try
    {
        Console.Write("Converter para ASCII\nInsira o texto: ");
        string text = Console.ReadLine();
        Console.WriteLine(WordToAscii(text));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();