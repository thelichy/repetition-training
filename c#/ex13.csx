/*13. Implementar uma função que retorne um texto que represente a forma de um quadrado a partir da 
quantidade de linhas, conforme abaixo:
*/

public string Square(int side)
{
    if (side <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    string rst = "";
    for (int row = 0; row < side; row++)
    {
        for (int i = 0; i < side; i++) rst += "* ";
        rst += "\n";
    }
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Desenhar quadrado\nInsert a numba: ");
        int numba = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Square(numba));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();