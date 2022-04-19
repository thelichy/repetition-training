/*01. Implementar uma função que escreva no terminal os números naturais de 1 até um número informado.
Ex: (10) => 1 2 3 4 5 6 7 8 9 10
*/

public string Count(int limit)
{
    if (limit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    string rst = ";";
    for (int i = 1; i <= limit; i++)
    {
        rst += i + " ";
    }
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Contar números\nInsira o limite: ");
        int lm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Count(lm));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nUm erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();