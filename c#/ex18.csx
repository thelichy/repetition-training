/*18. Implementar uma função que calcule a soma dos números pares naturais de 1 até um
 número informado.
*/
public string Sum(int limit)
{
    int rt = 0;
    string msg = "";
    for (int i = 2; i <= (limit % 2 != 0 ? limit - 1 : limit); i += 2)
    {
        msg += i + " + ";
        rt += i;
    }
    return msg + " = " + rt;
}

Console.WriteLine(Sum(5));