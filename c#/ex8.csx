/*08. Implementar uma função que escreva no terminal os números naturais, a partir de um número de início 
e fim, de forma decrescente.
Ex: (3, 11) => 11 10 9 8 7 6 5 4 3
*/

public void DecTypeNumbar(int ini, int limit)
{
    if (limit <= 0 || ini <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");

    for (int i = limit; i >= ini; i--)
    {
        Console.Write(i + " ");    
    }
}

DecTypeNumbar(3, 10);