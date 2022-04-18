/*25. Implementar uma função que retorne um texto que represente a forma de um triângulo a partir da 
quantidade de linhas, conforme abaixo:
*/

public void Triangle(int side)
{
    for (int row = 1; row <= side; row++)
    {
        for (int i = side; i >= row; i--) Console.Write(" ");
        for (int ii = 1; ii <= row; ii++)
        {
            Console.Write(row + " ");
        }
        Console.WriteLine();
    }
}

Triangle(4);