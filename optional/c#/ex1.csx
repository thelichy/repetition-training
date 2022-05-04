/* 01. Implementar uma função que recorte um texto a partir de uma posição e da quantidade de caracteres para recortar.*/
public string Substring(string phrase, int pos, int comp)
{
    if (pos < 0 || comp < 1 || comp > phrase.Length - pos + 1) throw new ArgumentException("Invalid values");

    string rst = "";
    for(int i = pos; i <= comp; i++) rst += phrase[i];
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Cut\nString: ");
        string ph = Console.ReadLine();
        Console.Write("Insert da position: ");
        int numba = Convert.ToInt32(Console.ReadLine());
        Console.Write("Insert da length: ");
        int numbar = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Substring(ph, numba, numbar));
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
            Console.WriteLine("\n");
            Main();
        }
    }
}

Main();