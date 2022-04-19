/*21. Implementar uma função que calcule a potenciação a partir de um número e do expoente. 
Obs: Essa versão da potenciação deve se preocupar apenas com números naturais, ou seja, 
inteiros positivos. Se a potência for zero, retorne 1. Se algum parâmetro for negativo, 
lançar um erro.
Ex: Potência de 3 elevado a 3 => 27
*/

public int Power(int numba, int exponent)
{
    if (numba <= 0) throw new ArgumentException("Numbers less than zero are not accepted, except the exponent");
    if (exponent == 0) return 0;
    int numbe = numba;
    for (int i = 1; i < exponent; i++) numbe *= numba;
    return numbe;
}

public void Main()
{
    try
    {
        Console.Write("Elevar à potência\nInsira um número: ");
        int numba = Convert.ToInt32(Console.ReadLine());
        Console.Write("Insira a potência: ");
        int numbar = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Power(numba, numbar));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();