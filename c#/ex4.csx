/*04. Implementar uma função que escreva no terminal os números naturais, a partir de um número de início e fim.
Ex: (3, 11) => 3 4 5 6 7 8 9 10 11
*/

public string TypeNumbar(int ini, int limit)
{
    if (limit <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    if (ini > limit) throw new ArgumentException("The first numba cant be bigger than the second numba");
    string rst = "";
    for (int i = ini; i <= limit; i++) rst += i + " ";
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Contar intervalo\nInsira o valor inicial: ");
        int vl = Convert.ToInt32(Console.ReadLine());
        Console.Write("Insira o valor limite: ");
        int lm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(TypeNumbar(vl, lm));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nUm erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();