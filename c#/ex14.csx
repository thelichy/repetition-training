/*14. Implementar uma função que retorne um texto que represente a forma de um retângulo a partir da quantidade de 
linhas e colunas, conforme abaixo:
Exemplo: 4 linhas e 2 colunas
*/

public string Rectangle(int side, int height)
{
    if (side <= 0 || height <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    string rst = "";
    for (int i = 0; i < side; i++)
    {
        for (int ii = 0; ii < height; ii++) rst += "* ";
        rst += "\n";
    }
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Desenhar retângulo\nInsira a base: ");
        int numba = Convert.ToInt32(Console.ReadLine());
        Console.Write("Insira a altura: ");
        int numbar = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Rectangle(numba, numbar));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();