/*12. Implementar uma função que retorne um texto que represente a forma de uma linha a partir do tamanho 
de pontos que a compõem, conforme abaixo:
Exemplo: 4 pontos
* * * *
*/

public void Row(int length)
{
    if (length <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    for (int row = 0; row < length; row++)
    {
        Console.Write("* ");
    }
}

