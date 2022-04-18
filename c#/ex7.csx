/*07. Implementar uma função que escreva no terminal os números naturais ímpares de 1 até um número
 informado de forma decrescente.
Ex: (10) => 9 7 5 3 1
*/

public void DecTypeEvenNumba(int limit)
{
    if (limit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");

    for (int i = (limit % 2 != 0 ? limit : limit - 1); i > 0 ; i--)
    {
        Console.Write(i + " ");
    }
}

DecTypeEvenNumba(6);