/*05. Implementar uma função que escreva no terminal os números naturais de 1 até um número
 informado de forma decrescente.
Ex: (10) => 10 9 8 7 6 5 4 3 2 1
*/

public string DecTypeNumba(int limit)
{
    if (limit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    string rst = "";
    for (int i = limit; i >= 1; i--)
    {
        rst += i + " ";
    }
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Contar até 0\nInsira o valor do contador: ");
        int cn = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(DecTypeNumba(cn));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nUm erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();