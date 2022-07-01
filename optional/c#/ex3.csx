/* 03. Implementar uma função que verifique se uma palavra aparece em um texto */

public bool Contem(string texto, string palavra)
{
    bool c;

    for (int i = 0; i < texto.Length; i++)
    {
        c = true;
        for (int j = 0; j < palavra.Length; j++)
        {
            if (texto[i + j] != palavra[j])
            {
                c = false;
                break;
            }
        }
        if (c) return true;
    }
    return false;
}

public void Main()
{
    try
    {
        Console.Write("Verificar\nString: ");
        char text = Console.ReadLine();
        Console.Write("Palavra: ");
        char word = Console.ReadLine();
        Console.WriteLine(Contem(text, word));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nAn error has ocurred: {ex.Message}\n");
        Main();
    }
    finally
    {
        Console.Write("Again? [Y/n] ");
        string repet  = Console.ReadLine().ToLower();
        if (repet == "n") 
        {
            Console.WriteLine("Goodbay");
            Environment.Exit(0);   
        }
        else if (repet == "" || repet == "y")
        {
            Console.WriteLine();
            Main();
        }
    }
}

Main();
