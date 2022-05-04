/* 38. Implementar uma função que converta uma palavra para Binário. */

public string StringToBinary(string phrase)
{
    int a = 0;
    string c = "";
    for (int i = 0; i < phrase.Length; i++)
    {
        a = Convert.ToInt32(phrase[i]);
        for (int ii = 128; ii >= 1; ii /= 2)
        {
            if (a >= ii) 
            {
                c += "1";
                a -= ii;
            }
            else c += "0";
        }
        c += " ";
    }
    return c;
}

public void Main()
{
    try
    {
        Console.Write("Converter para binário\nInsira o texto: ");
        string text = Console.ReadLine();
        Console.WriteLine(StringToBinary(text));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();