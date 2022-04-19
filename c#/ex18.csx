/*18. Implementar uma função que calcule a soma dos números pares naturais de 1 até um
 número informado.
*/
public string Sum(int limit)
{
    if (limit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    int rt = 0;
    string msg = "";
    for (int i = 2; i <= (limit % 2 != 0 ? limit - 1 : limit); i += 2)
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
        Console.Write("Somar pares até\nInsira o limite: ");
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