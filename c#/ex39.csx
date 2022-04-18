/*39. Implementar uma função que verifique, sim ou não, se um número é primo. */

public bool NumeroPrimo(int numba)
{
    int c = 0;
    for (int i = 2; i < numba; i++)
    {
        if (numba % i == 0) c += 1;
    }
    return c == 0 ? true : false;
}

Console.WriteLine(NumeroPrimo(11));