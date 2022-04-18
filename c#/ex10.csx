/*10. Implementar uma função que escreva no terminal o dobro dos números naturais de 1 até um número informado. 
A mensagem deve estar no formato: "O dobro de X é Y".
*/

public void Dobler(int limit)
{
    for (int i = 0; i < limit; i++)
    {
        Console.Write("O dobro de {0} é {1}", i, (i*2));
    }
}