/* 22. Implementar uma função que retorne um texto que represente a forma de um losango 
a partir da quantidade de linhas, conforme abaixo:
*/

public void Losango(int side)
{
    for (int row = 0; row <= side; row++)
    {
        for (int i = side; i > row; i--) Console.Write(" ");
        for (int ii = 0; ii < row; ii++) Console.Write(" *");
        Console.WriteLine();
    }
    for (int row = side - 1; row >= 0; row--)
    {
        for (int i = row; i < side; i++) Console.Write(" ");
        for (int ii = row; ii > 0; ii--) Console.Write(" *");
        Console.WriteLine();
    }
}


public void Losangoo(int side)
{
    for (int row = 0; row <= side; row++)
    {
        for (int i = side; i > row; i--) Console.Write("  ");
        for (int ii = 0; ii < row; ii++) Console.Write(" *");
        for (int iii = 0; iii <= row; iii++) Console.Write(" *");
        Console.WriteLine();
    }
    for (int roow = side - 1; roow >= 0; roow--)
    {
        for (int i = side; i > roow; i--) Console.Write("  ");
        for (int ii = roow; ii > 0; ii--) Console.Write(" *");
        for (int iii = roow; iii >= 0; iii--) Console.Write(" *");
        Console.WriteLine();
    }
}

Losango(3);
Losangoo(3);
