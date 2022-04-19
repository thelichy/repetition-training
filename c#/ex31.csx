/*31. Implementar uma função que conte a frequência de um digito em um número. */

public int ContarDigitos(int numba, int digit)
{
    if (numba <= 0 || digit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    string number = Convert.ToString(numba);
    char dig = Convert.ToChar(Convert.ToString(digit));
    int counter = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] == dig) counter++;
    }
    return counter;
}

public void Main()
{
    try
    {
        Console.Write("Contar a frequência dos dígitos\nInsira o número: ");
        int numba = Convert.ToInt32(Console.ReadLine());
        Console.Write("Insira o dígito: ");
        int digit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(ContarDigitos(numba, digit));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();