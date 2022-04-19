/*06. Implementar uma função que escreva no terminal os números naturais pares de 0 até um número 
informado de forma decrescente.
Ex: (10) => 10 8 6 4 2 0
*/

public string DecTypeOddNumba(int limit)
{
    if (limit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    string rst = "";
    for (int i = (limit % 2 == 0 ? limit : limit - 1); i > 0 ; i--) rst += i + " ";
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Contar pares até 0\nInsira o valor do contador: ");
        int cn = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(DecTypeOddNumba(cn));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nUm erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();