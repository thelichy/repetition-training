/*21. Implementar uma função que calcule a potenciação a partir de um número e do expoente. 
Obs: Essa versão da potenciação deve se preocupar apenas com números naturais, ou seja, 
inteiros positivos. Se a potência for zero, retorne 1. Se algum parâmetro for negativo, 
lançar um erro.
Ex: Potência de 3 elevado a 3 => 27
*/

public int Power(int numba, int exponent)
{
    int number = numba;
    for (int i = 1; i < exponent; i++)
    {
        number *= numba;
    }
    return number;
}

Console.WriteLine(Power(2, 10));