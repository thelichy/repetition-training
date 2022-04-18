/*17. Implementar uma função que calcule a soma dos números naturais de 1 até um número 
informado.
*/

public string Sum(int limit)
{
    int rt = 0;
    string msg = "";
    for (int i = 1; i <= limit; i++)
    {
        msg += i + " + ";
        rt += i;
    }
    return msg + " = " + rt;
}

Console.WriteLine(Sum(5));