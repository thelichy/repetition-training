/*03. Implementar uma função que escreva no terminal os números naturais ímpares de 1 até um número informado.
Ex: (10) => 1 3 5 7 9
*/

public string Even(int limit)
{
    if (limit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");

    string rst = "";
    for (int i = 1; i <= limit; i += 2) rst += i + " ";
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Contar ímpares\nInsira um limite: ");
        int lm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Even(lm));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nUm erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();