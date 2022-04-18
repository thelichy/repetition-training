/*11. Implementar uma função que escreva no terminal a tabuada de um número informado. A
 mensagem deve estar no formato: "A x B = X".
*/

public void Table(int firstNumba, int secondNumba)
{
    if (secondNumba <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");

    for(int i = 1; secondNumba >= i; i++)
    {
        Console.WriteLine(firstNumba + " x " + i + " = " + (firstNumba * i)); //Console.WriteLine("{0} x {1} = {2}", firstNumba, i, (firstNumba*i));
    }
}

public void Main()
{
    Console.Write("insert a numba: ");
    int numba = Convert.ToInt32(Console.ReadLine());
    Console.Write("insert a other numba: ");
    int numbaa = Convert.ToInt32(Console.ReadLine());
    Table(numba, numbaa);
}
Main();