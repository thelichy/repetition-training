/*09. Implementar uma função que escreva no terminal os números naturais múltiplos de número informado, 
de 0 até outro número informado.
Ex1: (4, 20) => 0, 4, 8, 12, 16, 20
Ex2: (6, 20) => 6, 12, 18
*/

public void DecTypeMult(int ini, int limit)
{
    if (limit <= 0 || ini <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    if (ini > limit) throw new ArgumentException("The first numba cant be bigger than the second numba");

    for (int i = 0; i <= limit; i += ini)
    {
        if (i % ini == 0)
        {
            Console.Write(i + " ");
        }
    }
}

DecTypeMult(4, 80);