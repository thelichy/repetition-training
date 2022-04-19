/* 16. Implementar uma função que retorne um texto que represente a forma de um triângulo
invertido a partir da quantidade de linhas, conforme abaixo:
Exemplo: 5 linhas
*/

public string RevTriangle(int side)
{
    if (side <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    string rst = "";
    for (int row = 0; row <= side; row++)
    {
        for (int i = side; i > row; i--) rst += "  ";
        for (int ii = 0; ii < row; ii++) rst += "* ";
        rst += "\n";
    }
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Desenhar retângulo espelhado\nInsira a numba: ");
        int numba = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(RevTriangle(numba));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();