/*26. Implementar uma função que retorne um texto que represente a forma de um triângulo a partir da quantidade
 de linhas, conforme abaixo:
*/

public void Triangle(int side)
{
    int x;
    for (int row = 1; row <= side; row++)
    {
        x = side;
        for (int i = side; i >= row; i--) Console.Write("  ");
        for (int ii = row; ii >0 ; ii--) Console.Write(ii + " ");
        for (int iii = 2; iii <= row; iii++) Console.Write(iii + " ");
        Console.WriteLine();
    }
}

Triangle(5);