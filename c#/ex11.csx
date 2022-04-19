/*11. Implementar uma função que escreva no terminal a tabuada de um número informado. A
 mensagem deve estar no formato: "A x B = X".
*/

public string Table(int firstNumba, int secondNumba)
{
    if (secondNumba <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    string rst = "";
    for(int i = 1; secondNumba >= i; i++) rst += $"{firstNumba} x {i} = {i * firstNumba}";
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Tabuada\ninsert a numba: ");
        int numba = Convert.ToInt32(Console.ReadLine());
        Console.Write("insert a other numba: ");
        int numbaa = Convert.ToInt32(Console.ReadLine());
        Table(numba, numbaa);   
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();