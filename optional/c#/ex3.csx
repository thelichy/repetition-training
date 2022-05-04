/* 03. Implementar uma função que verifique se uma palavra aparece em um texto */

public string Substring(string phrase, int pos, int comp)
{
    if (pos < 0 || comp < 1 || comp > phrase.Length - pos + 1) throw new ArgumentException("Invalid values");

    string rst = "";
    for(int i = pos; i <= comp; i++) rst += phrase[i];
    return rst;
}

public bool Contains(string phrase, string common)
{
    int counter  = 0;
    char rsp;
    for (int i = 0; i < phrase.Length; i++)
    {
        rsp = phrase[i];
        
    }
    return false;
}

Console.WriteLine(Contains("coisa bunita", "coisa"));