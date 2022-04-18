/*24. Implementar uma função que retorne um texto que represente a forma de um triângulo a partir da quantidade de 
linhas, conforme abaixo:
*/

public void Triangle(int side)
{
    int z = 0;
    for (int row = 1; row <= side; row++)
    {
        for (int i = 1; i <= row; i++)
        {
            z++;
            Console.Write(z + " ");
        }
        Console.WriteLine();
    }
}

Triangle(4);