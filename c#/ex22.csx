/* 22. Implementar uma função que retorne um texto que represente a forma de um losango 
a partir da quantidade de linhas, conforme abaixo:
*/

public string Losango(int side)
{
    if (side <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    string rst = "";
    for (int row = 0; row <= side; row++)
    {
        for (int i = side; i > row; i--) rst += " ";
        for (int ii = 0; ii < row; ii++) rst += " *";
        rst += "\n";
    }
    for (int row = side - 1; row >= 0; row--)
    {
        for (int i = row; i < side; i++) rst += " ";
        for (int ii = row; ii > 0; ii--) rst += " *";
        rst += "\n";
    }
    return rst;
}


public string Losangoo(int side)
{
    if (side <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    string rst = "";
    for (int row = 0; row <= side; row++)
    {
        for (int i = side; i > row; i--) rst += "  ";
        for (int ii = 0; ii < row; ii++) rst += " *";
        for (int iii = 0; iii <= row; iii++) rst += " *";
        rst += "\n";
    }
    for (int roow = side - 1; roow >= 0; roow--)
    {
        for (int i = side; i > roow; i--) rst += "  ";
        for (int ii = roow; ii > 0; ii--) rst += " *";
        for (int iii = roow; iii >= 0; iii--) rst += " *";
        rst += "\n";
    }
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Desenhar losango\nEscolha: losango 1 ou 2 - ");
        int ch = Convert.ToInt32(Console.ReadLine());
        Console.Write("Escolha o tamanho do lado: ");
        int numba = Convert.ToInt32(Console.ReadLine());
        if (ch == 1) Console.WriteLine(Losango(numba));
        else if (ch == 2) Console.WriteLine(Losangoo(numba));
        else throw new ArgumentException("Escolha apenas 1 ou 2");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();