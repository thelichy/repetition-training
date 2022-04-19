/*2. 02. Implementar uma função que escreva no terminal os números naturais pares de 0 até um número informado.
Ex: (10) => 0 2 4 6 8 10
*/

public string Odd(int limit)
{
    if (limit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    string rst = "";
    for (int i = 0; i <= limit; i += 2) rst += i + " ";
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Contar pares até\nInsira o limite: ");
        int lm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Odd(lm));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nUm erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();