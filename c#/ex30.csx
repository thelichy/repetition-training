/*30. Implementar uma função que conte a frequência de um caractere em um texto. */

public int ContarFrequencia(string phrase, string character)
{
    int counter = 0;
    for (int i = 0; i < phrase.Length; i++)
    {
        if (Convert.ToString(phrase[i]).ToLower().Contains(character)) counter++;
    }
    return counter;
}

public void Main()
{
    try
    {
        Console.Write("Contar a frequência de um caractere\nInsira o texto: ");
        string text = Console.ReadLine();
        Console.Write("Insira o caractere: ");
        string character = Console.ReadLine();
        Console.WriteLine(ContarFrequencia(text, character));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();