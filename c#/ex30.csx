/*30. Implementar uma função que conte a frequência de um caractere em um texto. */

public int ContarFrequencia(string phrase, string character)
{
    int counter = 0;
    for (int i = 0; i < phrase.Length; i++)
    {
        if (phrase.ToLower().Substring(i, 1).Contains(character)) counter++;
    }
    return counter;
}

