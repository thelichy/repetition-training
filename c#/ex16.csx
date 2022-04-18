/* 16. Implementar uma função que retorne um texto que represente a forma de um triângulo
invertido a partir da quantidade de linhas, conforme abaixo:
Exemplo: 5 linhas
*/

public void RevTriangle(int side)
{
    for (int row = 0; row <= side; row++)
    {
        for (int i = side; i > row; i--) Console.Write(" ");
        for (int ii = 0; ii < row; ii++) Console.Write("*");
        Console.WriteLine();
    }
}

RevTriangle(6);