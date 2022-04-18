/*20. Implementar uma função que calcule o fatorial de um número informado.*/

public string Factorial(int numba)
{
    int rt = 1;
    string msg = "";
    for (int i = numba; i >= 1; i--)
    {
        msg += i + " x ";
        rt *= i;
    }
    return msg + " = " + rt;
}

Console.WriteLine(Factorial(6));