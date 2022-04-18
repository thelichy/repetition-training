/*2. 02. Implementar uma função que escreva no terminal os números naturais pares de 0 até um número informado.
Ex: (10) => 0 2 4 6 8 10
*/

public void Odd(int limit)
{
    if (limit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    for (int i = 0; i <= limit; i += 2)
    {
        Console.Write(i + " ");
    }
}

Odd(8);