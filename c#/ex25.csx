/*25. Implementar uma função que retorne um texto que represente a forma de um triângulo a partir da 
quantidade de linhas, conforme abaixo:
*/

public string Triangle(int side)
{
    if (side <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    string rst = "";
    for (int row = 1; row <= side; row++)
    {
        for (int i = side; i >= row; i--) rst += " ";
        for (int ii = 1; ii <= row; ii++) rst += row + " ";
        rst += "\n";
    }
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Desenhar triângulo\nInsira o valor do lado: ");
        int numba = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Triangle(numba));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();