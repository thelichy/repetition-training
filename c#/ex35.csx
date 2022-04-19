/*35. Implementar uma função que verifique se um número é um palíndromo. */

public bool Palindromo(int numba)
{
    if (numba <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    string rsp = "";
    string phrase = numba + "";
    for (int i = phrase.Length - 1; i >= 0; i--) rsp += phrase[i];
    if (rsp.Replace(" ", "") == phrase.Replace(" ", "")) return true;
    else return false;
}

public void Main()
{
    try
    {
        Console.Write("Verificar se um número é um palíndromo\nInsira o número: ");
        int numba = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Palindromo(numba));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();