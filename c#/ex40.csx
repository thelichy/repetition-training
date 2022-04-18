/* 40. Implementar uma função que verifique qual é o número da sequência de 
fibonacci, a partir de uma posição informada.
Sequência Fibonacci: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89
*/

public int Fibonacci(int pos)
{
    int numba = 1;
    int prevnumba = 1;
    for (int i = 0; i < pos; i++)
    {
        numba += prevnumba;
        prevnumba += numba - prevnumba;
    }
    return numba;
}

Console.WriteLine(Fibonacci(11));