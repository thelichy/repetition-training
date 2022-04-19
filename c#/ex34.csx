/*34. Implementar uma função que inverta os digitos de um número recebido. */

public int Inverter(int numba)
{
    string rsp = "";
    string phrase = numba.ToString();
    for (int i = phrase.Length - 1; i >= 0; i--)
    {
        rsp += phrase.Substring(i, 1);
    }
    return Convert.ToInt32(rsp);
}

public void Main()
{
    try
    {
        Console.Write("Inverter os dígitos de um número\nInsira o número: ");
        int numba = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Inverter(numba));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();