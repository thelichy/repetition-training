/*03. Implementar uma função que escreva no terminal os números naturais ímpares de 1 até um número informado.
Ex: (10) => 1 3 5 7 9
*/

public void Even(int limit)
{
    if (limit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    
    for (int i = 1; i <= limit; i += 2)
    {
        Console.Write(i + " ");        
    }
}