/*39. Implementar uma função que verifique, sim ou não, se um número é primo. */

public bool NumeroPrimo(int numba)
{
    if (numba <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    int c = 0;
    for (int i = 2; i < numba; i++)
    {
        if (numba % i == 0) c += 1;
    }
    return c == 0 ? true : false;
}

public void Main()
{
    try
    {
        Console.Write("Verificar se um número é primo\nInsira o número: ");
        int numbas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(NumeroPrimo(numbas));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();