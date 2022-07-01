// Implementar uma função que retorne a posição de um caractere em um texto.

public int Indexe(string text, char chara)
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == chara) return i;
    }
    return -1;
}

public void Main()
{
    try
    {
        Console.Write("Index\nString: ");
        string text = Console.ReadLine();
        Console.Write("Char: ");
        char word = Convert.ToChar(Console.ReadLine());
        Console.WriteLine(Indexe(text, word));
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
