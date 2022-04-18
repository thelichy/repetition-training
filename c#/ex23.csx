/*23. Implementar uma função que retorne um texto que represente a forma de um triângulo a partir da quantidade de 
linhas, conforme abaixo:
*/

public void Triangle(int side)
{
    for (int row = 1; row <= side; row++)
    {
        for (int i = 1; i <= row; i++)
        {
            Console.Write(row + " ");
        }
        Console.WriteLine();
    }
}

Triangle(5);