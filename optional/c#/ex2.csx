/* 02. Implementar uma função que substitua um caracter por outro em um texto. */

public string Replace(string phrase, char com, char rpl)
{
    string rst = "";
    for (int i = 0; i < phrase.Length; i++)
    {
        if (phrase[i] == com) rst += rpl;
        else rst += phrase[i];
    }
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Cut\nString: ");
        string ph = Console.ReadLine();
        Console.Write("Common char: ");
        char cchar = Convert.ToChar(Console.ReadLine());
        Console.Write("Replacer: ");
        char rchar = Convert.ToChar(Console.ReadLine());
        Console.WriteLine(Replace(ph, cchar, rchar));
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