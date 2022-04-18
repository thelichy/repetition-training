/*06. Implementar uma função que escreva no terminal os números naturais pares de 0 até um número 
informado de forma decrescente.
Ex: (10) => 10 8 6 4 2 0
*/

public void DecTypeOddNumba(int limit)
{
    if (limit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");

    for (int i = (limit % 2 == 0 ? limit : limit - 1); i > 0 ; i--)
    {
        Console.Write(i + " ");
    }
}

DecTypeOddNumba(6);