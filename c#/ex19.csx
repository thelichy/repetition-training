/*19. Implementar uma função que calcule a soma dos números ímpares naturais de 1 até
um número informado.
*/

public string Sum(int limit)
{
    if (limit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    int rt = 0;
    string msg = "";
    for (int i = 1; i <= limit; i += 2)
    {
        if (i == limit) msg += i;
        else msg += i + " + ";
        rt += i;
    }
    return $"{msg} = {rt}";
}

public void Main()
{
    try
    {
        Console.Write("Somar ímpares até\nInsira o limite: ");
        int numba = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Sum(numba));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();