/*33. Implementar uma função que verifique se um texto é um palíndromo. */

public bool Palindromo(string words)
{
    string phrase = words.ToLower();
    string rsp = "";
    for (int i = phrase.Length - 1; i >= 0; i--) rsp += phrase.Substring(i, 1);
    if (rsp.Replace(" ", "") == phrase.Replace(" ", "")) return true;
    else return false;
}

Console.WriteLine(Palindromo("Luz Azul"));