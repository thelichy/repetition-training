/*32. Implementar uma função que inverta os caracteres de um texto recebido. */

public string Inverter(string phrase)
{
    string rsp = "";
    for (int i = phrase.Length - 1; i >= 0; i--)
    {
        rsp += phrase.Substring(i, 1);
    }
    return rsp;
}

Console.WriteLine(Inverter("Olha só que legal"));