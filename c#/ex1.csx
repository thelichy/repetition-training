/*01. Implementar uma função que escreva no terminal os números naturais de 1 até um número informado.
Ex: (10) => 1 2 3 4 5 6 7 8 9 10
*/

public void Count(int limit)
{
    if (limit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    for (int i = 1; i <= limit; i++)
    {
        Console.Write(i + " ");
    }
}

Count(6);