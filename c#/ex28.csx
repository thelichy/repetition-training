/* 28. Implementar uma função que verifique quantas vogais aparecem em um texto. */

public int FindVowels(string words)
{
    string phrase = words.ToLower();
    int rsp = 0;
    for (int i = 0; i < phrase.Length; i++)
    {
        if (phrase.Substring(i, 1).Contains("a") || phrase.Substring(i, 1).Contains("e") || phrase.Substring(i, 1).Contains("i") || phrase.Substring(i, 1).Contains("o") || phrase.Substring(i, 1).Contains("u")) rsp += 1;
    }
    return rsp;
}

Console.WriteLine(FindVowels("olha que loco"));