/*05. Implementar uma função que escreva no terminal os números naturais de 1 até um número
 informado de forma decrescente.
Ex: (10) => 10 9 8 7 6 5 4 3 2 1
*/

public void DecTypeNumba(int limit)
{
    if (limit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");

    for (int i = limit; i >= 1; i--)
    {
        Console.Write(i + " ");
    }
}

DecTypeNumba(5);