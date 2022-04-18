/*27. Implementar uma função que separe os caracteres de um texto por hífen. */

public string SeparatorUltraThreeThousand(string phrase)
{
    string rsp = "";
    for (int i = 0; i < phrase.Length; i++)
    {
        rsp += phrase.Substring(i, 1) + "-";
    }
    return rsp;
}

Console.WriteLine(SeparatorUltraThreeThousand("aiaiai que coisa bunita"));