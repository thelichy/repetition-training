/* Implementar uma função que verifique se todas as vogais aparecem em um texto. */

public bool NiceBoi(string words)
{
    int a = 0;
    int e = 0;
    int i = 0;
    int o = 0;
    int u = 0;
    string phrase = words.ToLower();
    for (int ii = 0; ii < phrase.Length; ii++)
    {
        if (phrase.ToLower().Substring(ii, 1).Contains("a")) a = 1;
        if (phrase.ToLower().Substring(ii, 1).Contains("e")) e = 1;
        if (phrase.ToLower().Substring(ii, 1).Contains("i")) i = 1;
        if (phrase.ToLower().Substring(ii, 1).Contains("o")) o = 1;
        if (phrase.ToLower().Substring(ii, 1).Contains("u")) u = 1;
    }
    return a + e + i + o + u == 5 ? true : false;
}

Console.WriteLine(NiceBoi("olha só, que dia maravilhoso"));