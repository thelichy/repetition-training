/*35. Implementar uma função que verifique se um número é um palíndromo. */

public bool Palindromo(int numba)
{
    string rsp = "";
    string phrase = numba.ToString(); //string phrase = numba + "";
    for (int i = phrase.Length - 1; i >= 0; i--) rsp += phrase.Substring(i, 1);
    if (rsp.Replace(" ", "") == phrase.Replace(" ", "")) return true;
    else return false;
}

Console.WriteLine(Palindromo(12321));