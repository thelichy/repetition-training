/* 40. Implementar uma função que verifique qual é o número da sequência de 
fibonacci, a partir de uma posição informada.
Sequência Fibonacci: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89
*/

public string Fibonacci(int pos)
{
    if (pos <= 2) throw new ArgumentException("Numbers less or equals than 2 are not accepted");
    int numba = 1;
    int prevnumba = 1;
    int rst = 0;
    string rsp = "";
    for (int i = 2; i < pos; i++)
    {
        rst = numba + prevnumba;
        if (i == pos - 1) rsp += rst;
        else rsp += rst + ", ";
        prevnumba = numba;
        numba = rst;
    }
    return rsp;
}

public void Main()
{
    try
    {
        Console.Write("Sequência de Fibonacci\nInsira a posição: ");
        int numba = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fibonacci(numba));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();