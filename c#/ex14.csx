/*14. Implementar uma função que retorne um texto que represente a forma de um retângulo a partir da quantidade de 
linhas e colunas, conforme abaixo:
Exemplo: 4 linhas e 2 colunas
*/

public void Rectangle(int side, int otherSide)
{
    for (int i = 0; i < side; i++)
    {
        for (int ii = 0; i < otherSide; ii++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}