/*10. Implementar uma função que escreva no terminal o dobro dos números naturais de 1 até um número informado. 
A mensagem deve estar no formato: "O dobro de X é Y".
*/

public string Dobler(int limit)
{
    if (limit <= 0) throw new ArgumentException("The numbas cant be minor than one");
    string rst = "";
    for (int i = 0; i < limit; i++)
    {
        rst += $"O dobro de {i} é {i*2}\n";
    }
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("\nInsira o valor do limite: ");
        int lm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Dobler(lm));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nUm erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();