/*04. Implementar uma função que escreva no terminal os números naturais, a partir de um número de início e fim.
Ex: (3, 11) => 3 4 5 6 7 8 9 10 11
*/

public void TypeNumbar(int ini, int limit)
{
    if (limit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");

    for (int i = ini; i <= limit; i++)
    {
        Console.Write(i + " ");    
    }
}