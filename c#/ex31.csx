/*31. Implementar uma função que conte a frequência de um digito em um número. */

public int ContarDigitos(int numba, int digit)
{
    string number = Convert.ToString(numba), dig = Convert.ToString(digit);
    int counter = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number.ToLower().Substring(i, 1).Contains(dig)) counter++;
    }
    return counter;
}