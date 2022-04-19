/*20. Implementar uma função que calcule o fatorial de um número informado.*/

public string Factorial(int numba)
{
    if (numba <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    int rt = 1;
    string msg = "";
    for (int i = numba; i >= 1; i--)
    {
        if (i == 1) msg += i;
        else msg += i + " x ";
        rt *= i;
    }
    return $"{msg} = {rt}";
}

public void Main()
{
    try
    {
        Console.Write("Fatorial\nInsira um número: ");
        int numba = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Factorial(numba));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();