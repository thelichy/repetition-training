/*41. Implementar uma função que implemente a criptografia ZENIT POLAR. */

public string ZenitPolar(string phrase)
{
    phrase = phrase.ToLower();
    string rst = "";
    for (int i = 0; i < phrase.Length; i++)
    {
        char a = phrase[i];
        if (a == 'z') rst += 'p';
        else if (a == 'p') rst += 'z';
        else if (a == 'e') rst += 'o';
        else if (a == 'o') rst += 'e';
        else if (a == 'n') rst += 'l';
        else if (a == 'l') rst += 'n';
        else if (a == 'i') rst += 'a';
        else if (a == 'a') rst += 'i';
        else if (a == 't') rst += 'r';
        else if (a == 'r') rst += 't';
        else rst += a;
    }
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Criptografia Zenit Polar\nInsira um texto: ");
        string text = Console.ReadLine();
        Console.WriteLine(ZenitPolar(text));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();