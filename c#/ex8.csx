/*08. Implementar uma função que escreva no terminal os números naturais, a partir de um número de início 
e fim, de forma decrescente.
Ex: (3, 11) => 11 10 9 8 7 6 5 4 3
*/

public string DecTypeNumbar(int ini, int limit)
{
    if (limit <= 0 || ini <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    if (ini < limit) throw new ArgumentException("The second numba cant be bigger than the first numba");
    string rst = "";
    for (int i = limit; i >= ini; i--)
    {
        rst += i + " ";    
    }
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Contar até um número decrescente\nInsira o valor do contador: ");
        int cn = Convert.ToInt32(Console.ReadLine());
        Console.Write("Insira o valor do número limite: ");
        int lm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(DecTypeNumbar(cn, lm));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nUm erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();